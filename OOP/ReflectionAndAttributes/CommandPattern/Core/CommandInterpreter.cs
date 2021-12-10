using CommandPattern.Commands;
using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string commandPostFix = "Command";
        public string Read(string args)
        {
            string[] parts = args.Split(" ");
            string commandName = parts[0];
            string commandTypeName = commandName + commandPostFix;

            Type commandType = Assembly.GetCallingAssembly()
                .GetTypes()
                .Where(t => t.GetInterfaces().Any(i => i.Name == nameof(ICommand)))
                .FirstOrDefault(t => t.Name == commandTypeName);

            if (commandType == null)
            {
                throw new InvalidOperationException("Command type is invalid!");
            }

            ICommand command  = Activator.CreateInstance(commandType) as ICommand;

            string[] data = parts.Skip(1).ToArray();
            string result = command.Execute(data);

            return result;
        }
    }
}
