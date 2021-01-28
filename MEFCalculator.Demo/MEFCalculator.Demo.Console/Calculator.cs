using MEFCalculator.Demo.Base.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;

namespace MEFCalculator.Demo.Console
{
    public class Calculator
    {
        private CompositionContainer _container;
        private string _imputString;

        [ImportMany]
        IEnumerable<Lazy<IOperation, IOperationMetadata>> _operations;

        public Calculator()
        {
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(@"..\..\Operations"));
            _container = new CompositionContainer(catalog);

            try
            {
                _container.ComposeParts(this);
            }
            catch (CompositionException ex)
            {
                ConsoleHelper.Error(ex);
            }

            Init();
        }

        private void Init()
        {
            ConsoleHelper.PrintCommands(_operations.Select(o => o.Metadata).ToList());

            // Just for example, how Extension methodes works
            foreach(var operation in _operations)
            {
                PrintOperation(operation);
            }
        }

        private decimal RandomDigit()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            return rnd.Next(1, 25);
        }

        private void PrintOperation(Lazy<IOperation, IOperationMetadata> operation)
        {
            var digit1 = RandomDigit();
            var digit2 = RandomDigit();

            System.Console.WriteLine($"{digit1} {operation.Metadata.Command} {digit2} = {operation.Value.Run(digit1, digit2).Result}");
        }
    }
}
