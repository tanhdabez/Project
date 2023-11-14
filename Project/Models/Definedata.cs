namespace Project.Models
{
    public class Definedata
    {
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static double DateTimeToUnixTimeStamp(DateTime? time)
        {
            if (time == null)
                return 0;
            DateTime dt = time ?? DateTime.Now;
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            var epoch = (dt - dtDateTime).TotalSeconds;
            return epoch;
        }
        public enum eTrangThaiThaiLopHoc
        {
            DANGHOC,
            DADUNG,
            TAMNGHI
        }
        public enum eTrangThaiTKB
        {
            DAHOC,
            NGHI,
            CHUAHOC
        }
        public enum eTrangThaiGV
        {
            DANGDAY,
            DADUNG,
            TAMNGHI
        }
        public enum eTrangThaiHocPhi
        {
            DANOP
        }
        public static string QuyDoiThu(int i)
        {
            string sTT = "";
            switch (i)
            {
                case 0:
                    sTT = "Chủ Nhật";
                    break;
                case 1:
                    sTT = "Thứ hai";
                    break;
                case 2:
                    sTT = "Thứ Ba";
                    break;
                case 3:
                    sTT = "Thứ Tư";
                    break;
                case 4:
                    sTT = "Thứ Năm";
                    break;
                case 5:
                    sTT = "Thứ Sáu";
                    break;
                case 6:
                    sTT = "Thứ Bảy";
                    break;


            }
            return sTT;
        }
        public static string QuyDoiThuTA(int i)
        {
            string sTT = "";
            switch (i)
            {
                case 0:
                    sTT = "Sunday";
                    break;
                case 1:
                    sTT = "Monday";
                    break;
                case 2:
                    sTT = "Tuesday";
                    break;
                case 3:
                    sTT = "Wednesday";
                    break;
                case 4:
                    sTT = "Thursday";
                    break;
                case 5:
                    sTT = "Friday";
                    break;
                case 6:
                    sTT = "Saturday";
                    break;


            }

            return sTT;
        }

    }
}
