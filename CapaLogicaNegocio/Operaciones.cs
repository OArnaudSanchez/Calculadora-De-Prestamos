using System;
using System.Windows.Forms;
using CapaDatos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;

namespace CapaLogicaNegocio
{
    public class Operaciones
    {

        public static void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Alerta!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }


        public static Boolean ValidarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static string InsertarFactura(double pago,double interes, int idPrestamo,int idCliente,int idUsuario)
        {
            DatosFactura factura = new DatosFactura();

            factura.TotalPago = pago;
            factura.InteresTotal = interes;
            factura.idPrestamo = idPrestamo;
            factura.idCliente = idCliente;
            factura.idUsuario = idUsuario;
            return factura.Ingresar(factura);
        }

        public static double funcion(double pMonto, double pTasa, int pPlazo)
        {
            double CuotaFijaProgramada = 0;
            double monto = pMonto;
            double tasa = (pTasa / 100) / 12;
            int plazos = pPlazo * 12;

            int p = plazos * -1;
            double b = (1 + tasa);
            double a = (1 - Math.Pow(b, p)) / tasa;

            CuotaFijaProgramada = (monto / a);
            CuotaFijaProgramada = Math.Round(CuotaFijaProgramada, 2);

            return CuotaFijaProgramada;
        }

        public void procedimiento(double vMonto, double vTasa, int vPlazo, DateTime vFecha, double vPagoExtra,

          DataGridView dataPrestamo
          )
        {

   
            double monto = vMonto;
            double tasa = vTasa;
            int plazo = vPlazo;
            DateTime fecha = vFecha;

            double pagoextra = vPagoExtra;
            DateTime fechasaldo = vFecha;
            double interes = 0;
            double capital = 0;
            double resultadoFuncion = 0;
            double interesAcumulado = 0;

            resultadoFuncion = funcion(monto, tasa, plazo);
            pagoextra = Math.Round(pagoextra, 2);
            fecha = DateTime.Now;

            fechasaldo = fecha.AddMonths(Convert.ToInt32(plazo * 12));

            for (int i = 0; i < plazo * 12; i++)
            {

                interes = monto * ((tasa / 100) / 12);
                capital = resultadoFuncion - interes;
                monto = monto - capital;
                interesAcumulado += interes;

                dataPrestamo.Rows.Add(i, fecha.AddMonths(i).ToString("d"), Math.Round(monto, 2), Math.Round(resultadoFuncion, 2), pagoextra, Math.Round(resultadoFuncion, 2), Math.Round(capital, 2), Math.Round(interes, 2), Math.Truncate(monto));


            }
        }

        public static void ExportarPDF(DataGridView data, string fileName)
        {
            try
            {
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                PdfPTable pdftable = new PdfPTable(data.Columns.Count);
                pdftable.DefaultCell.Padding = 3;
                pdftable.WidthPercentage = 100;
                pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdftable.DefaultCell.BorderWidth = 1;

                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

                //Add Header
                foreach (DataGridViewColumn column in data.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdftable.AddCell(cell);
                }

                //Add DataRow
                foreach (DataGridViewRow row in data.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                    }
                }

                var salvarArchivo = new SaveFileDialog();
                salvarArchivo.FileName = fileName;
                salvarArchivo.DefaultExt = ".pdf";
                salvarArchivo.Filter = "Pdf Files|*.pdf";
                if (salvarArchivo.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(salvarArchivo.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdftable);
                        pdfDoc.Close();
                        stream.Close();
                    }
                    MessageBox.Show("Los datos se exportaron Correctamente", "Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Los datos no se Exportaron");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Los datos no pudieron ser exportados", "Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           
        }

        public static void ExportarEXCEL(DataGridView data, string FileName)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.InitialDirectory = "C";
                dialog.Title = "SAVE AS EXCEL FILE";
                dialog.FileName = FileName;

                dialog.Filter = "Excel Files (2007|*.xlsx|Excel Files(.CSV)|*.csv";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();

                    exportarExcel.Application.Workbooks.Add(true);
                    int indiceColumna = 0;

                    foreach (DataGridViewColumn columna in data.Columns)
                    {
                        indiceColumna++;

                        exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
                    }

                    int indiceFila = 0;
                    foreach (DataGridViewRow fila in data.Rows)
                    {
                        indiceFila++;
                        indiceColumna = 0;

                        foreach (DataGridViewColumn columna in data.Columns)
                        {
                            indiceColumna++;
                            exportarExcel.Cells[indiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;

                        }
                    }
                    exportarExcel.ActiveWorkbook.SaveCopyAs(dialog.FileName);
                    exportarExcel.ActiveWorkbook.Saved = true;
                    exportarExcel.Quit();
                    MessageBox.Show("Los datos se exportaron Correctamente","Alerta!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no se Exportaron");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Los datos no pudieron ser exportados", "Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

    }
}
