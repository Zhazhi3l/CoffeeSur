using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeSur.Servicios;

namespace CoffeeSur.UI
{
	public partial class FrmAuditorias : Form
	{
		private AuditoriaService _servicio = new AuditoriaService();

		public FrmAuditorias()
		{
			InitializeComponent();
		}

		private void FrmAuditorias_Load(object sender, EventArgs e)
		{
			
		}

		private void btnUsuarios_Click(object sender, EventArgs e)
		{
			CargarAuditoriaUsuarios();
		}

		private void btnProductos_Click(object sender, EventArgs e)
		{
			CargarAuditoriaProductos();
		}

		private void btnVentas_Click(object sender, EventArgs e)
		{
			CargarAuditoriaVentas();
		}

		private void CargarAuditoriaProductos()
		{
			try
			{
				var lista = _servicio.ObtenerAuditoriaProductos();
				MostrarDatosEnGrid(lista, "Productos");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar auditoría de productos: " + ex.Message);
			}
		}

		private void CargarAuditoriaVentas()
		{
			try
			{
				var lista = _servicio.ObtenerAuditoriaVentas();
				MostrarDatosEnGrid(lista, "Ventas");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar auditoría de ventas: " + ex.Message);
			}
		}

		private void CargarAuditoriaUsuarios()
		{
			try
			{
				var lista = _servicio.ObtenerAuditoriaUsuarios();
				MostrarDatosEnGrid(lista, "Usuarios");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar auditoría de usuarios: " + ex.Message);
			}
		}

		private void MostrarDatosEnGrid(List<CoffeeSur.DTO.AuditoriaGenericaDTO> lista, string tipo)
		{
			// Limpiar el DataGridView
			dgvAuditorias.DataSource = null;

			DataTable dt = new DataTable();
			dt.Columns.Add("ID Auditoría");
			dt.Columns.Add("ID Registro");
			dt.Columns.Add("Acción");
			dt.Columns.Add("Fecha");
			dt.Columns.Add("Usuario BD");
			dt.Columns.Add("Detalles");

			foreach (var auditoria in lista)
			{
				dt.Rows.Add(
					auditoria.IdAuditoria,
					auditoria.IdReferenciaObjeto,
					auditoria.Accion,
					auditoria.Fecha,
					auditoria.Usuario,
					auditoria.Detalles
				);
			}

			dgvAuditorias.DataSource = dt;

			dgvAuditorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvAuditorias.ReadOnly = true;
			dgvAuditorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}
	}
}
