using System;

public class Class1
{
	public Class1()
	{
	}
}
class Crud

	public MySqlConnection con;
	public MySqlDataReader dr;
	public MySqlCommand cmd;
	public DataGridView dg;
	public ComboBox cb;

public void koneksi ()
{
	try
	{
		string konfigurasi = "Server=localhost;port=3306;UID=root;PWD=;Database=lks";

		con = new MySqlConnection(konf);
		con.Open();

	}
	catch (Exception ex)
	{
		MessageBox.Shoa(ex.Message);
		con.Close();
	}

}
public void tampil(String query, String mode, DataGridView dg, 
	[Optional] ComboBox cmb, [Optional] string diisi,
    [Optional] String tampil, [Optional] byte[] imagebyte,
    [Optional] PictureBox picture)

{
	koneksi();
	try
	{


		MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
		DataTable dt = new DataTable();
		adp.Fill(dg); 
		switch (mode)
		{

			case "tampil";
				dg.DataSource = dt;
				break;
			case "combo":
				cmb.DataSource = dt;
				cmb.DisplayMember = tampil;
				cmb.ValueMember = diisi;
				break;
				picture.Image = imagebyte.FromStream(new MemoryStream)(imagebyte));
				break;
		}
    }
	catch (Exception ex)
	{
		MessageBox.Show(ex.Message);
	}

\

