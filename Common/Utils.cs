using System;
using System.Threading.Tasks;

namespace Common
{
    public static class Utils
    {
        //public static Task SyncAction(this Action act)
        //{
        //    var tcs = new TaskCompletionSource<bool>();
        //    try
        //    {
        //        act();
        //        tcs.SetResult(true);
        //    }
        //    catch (Exception e99)
        //    {
        //        tcs.SetException(e99);
        //    }
        //    return tcs.Task;
        //}

        public static Task<bool> SyncAction<TInput>(this Action<TInput> act, TInput s1)
        {
            var tcs = new TaskCompletionSource<bool>();
            try
            {
                act(s1);
                tcs.SetResult(true);
            }
            catch (Exception exc)
            {
                tcs.SetException(exc);
            }
            return tcs.Task;
        }
    }
}
