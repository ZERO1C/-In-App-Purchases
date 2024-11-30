// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("8MSbqrw7/s1OJI4QoAXsaWGw2wyoWq++JvJ5qQnmnqGEFPuwILmwe8eY1pjK2Hgvdy3XDM6z5/pQ3xiMP15rFdKiihdgcCanSHiDCpx5mOmyMvzn88DayiDH4gApLpOhSkkBA7Q3OTYGtDc8NLQ3NzaR/p/H2laUZhzl/6Rj0VzzxfBNZgNcbD0NTIEHCn/WD7qyISqvvtm2y7Mr2Asv7Y1rkotHzZZglZoyBxyDrRxgXtO/c3bgA0dsjBUEpFv8TuIt+gKKGooGtDcUBjswPxywfrDBOzc3NzM2NdfdsQqz4yBvjE6r8YYtF6PbeBgIZKVfelxKD4adFeuZZwKBUdzk3WcLXNeOSaoRmOwXWr26ISHnn8N1GB+3FeVZy6xF6zQ1NzY3");
        private static int[] order = new int[] { 10,9,13,3,11,9,8,9,13,12,10,13,12,13,14 };
        private static int key = 54;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
