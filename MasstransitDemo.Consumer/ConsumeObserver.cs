using MassTransit;
using MassTransit.Util;

namespace MasstransitDemo.Consumer;

public class ConsumeObserver : IConsumeObserver
{
    Task IConsumeObserver.PreConsume<T>(ConsumeContext<T> context)
    {
        return TaskUtil.Completed;
    }

    Task IConsumeObserver.PostConsume<T>(ConsumeContext<T> context)
    {
        return TaskUtil.Completed;
    }

    Task IConsumeObserver.ConsumeFault<T>(ConsumeContext<T> context, Exception exception)
    {
        //var request = context.Message;

        //var requestJson = Newtonsoft.Json.JsonConvert.SerializeObject(request);

        //var exceptionMessage = $"Exception Message: {exception.Message}\n\n";

        //if (exception.InnerException != default)
        //{
        //    exceptionMessage += $"InnerException Message: {exception.InnerException.Message}\n\n";
        //    exceptionMessage += $"InnerException StackTrace: {exception.InnerException.StackTrace}\n\n";
        //}

        //Log.Error($"request: {requestJson} {exceptionMessage}", exception);

        return TaskUtil.Completed;
    }
}