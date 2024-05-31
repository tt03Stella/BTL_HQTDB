using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

internal static class FunctionsHelpers
{
    public static SqlConnection Con { get; private set; }

    public static void Connect()
    {

        Con = new SqlConnection(); //Khởi tạo đối tượng
        Con.ConnectionString = QLBanHang.Properties.Settings.Default.BanMPConnectionString;//connectionString =@"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + @"\Quanlybanhang.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
                                                                                 //Kiểm tra kết nối
        if (Con.State != ConnectionState.Open)
        {
            Con.Open();          //Mở kết nối
            MessageBox.Show("Kết nối thành công");
        }
        else MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


    }

   
}