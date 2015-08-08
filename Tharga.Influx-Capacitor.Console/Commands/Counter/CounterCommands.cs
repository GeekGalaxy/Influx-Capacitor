﻿using Tharga.Toolkit.Console.Command.Base;

namespace Tharga.InfluxCapacitor.Console.Commands.Counter
{
    internal class CounterCommands : ContainerCommandBase
    {
        public CounterCommands(ICompositeRoot compositeRoot)
            : base("Counter")
        {
            RegisterCommand(new CounterListCommand(compositeRoot.ConfigBusiness, compositeRoot.CounterBusiness));
            //RegisterCommand(new CounterDisableCommand(compositeRoot.ConfigBusiness, compositeRoot.CounterBusiness));
            RegisterCommand(new CounterReadCommand(compositeRoot.ConfigBusiness, compositeRoot.CounterBusiness));
            RegisterCommand(new CounterCollectCommand(compositeRoot.ConfigBusiness, compositeRoot.CounterBusiness, compositeRoot.InfluxDbAgentLoader));
            RegisterCommand(new CounterInitiateCommand(compositeRoot.ConfigBusiness, compositeRoot.CounterBusiness));
            RegisterCommand(new CounterCreateCommand(compositeRoot.ConfigBusiness, compositeRoot.CounterBusiness));
        }
    }
}