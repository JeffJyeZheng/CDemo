using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Class1 : IClass1
    {
        private readonly ILogger Logger;

        public Class1(ILogger logger)
        {
            this.Logger = logger;
        }

        public void Log()
        {
            this.Logger.Trace("我是追蹤:Trace");
            this.Logger.Debug("我是偵錯:Debug");
            this.Logger.Info("我是資訊:Info");
            this.Logger.Warn("我是警告:Warn");
            this.Logger.Error("我是錯誤:error");
            this.Logger.Fatal("我是致命錯誤:Fatal");
        }
    }
}
