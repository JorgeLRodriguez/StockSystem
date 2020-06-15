using System;
using System.Data;
using System.Text.RegularExpressions;

namespace BLL
{
    public class remito_stockBLL
    {
        int CountErrores;
        public bool validaDatos(DataTable dt)
        {
            for (int y = 0; y < dt.Rows.Count; y++)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    switch (i)
                    {
                        case 0: //Fecha
                            IsDate(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            break;
                        case 1: //CuitEmpresa
                            IsNumber(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            if (Convert.ToString(dt.Rows[y][i]).Length != 11)
                            {
                                AddLog(dt.Columns[i].ColumnName + " : Debe tener 11 dígitos sin guiones ni espacios. Posición:[" + Convert.ToString(y + 1) + "]");
                            }
                            break;
                        case 2: //LetraRemito
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 0);
                            IsString(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            break;
                        case 3: //SucursalRemito
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 4);
                            IsNumber(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            break;
                        case 4: //NumeroRemito
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 8);
                            IsNumber(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            break;
                        case 5: //DestinatarioDocumentoTipo
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 0);
                            IsNumber(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            if (Convert.ToInt32(dt.Rows[y][i]) > 6 || Convert.ToInt32(dt.Rows[y][i]) < 1)
                            {
                                AddLog(dt.Columns[i].ColumnName+": Debe estar en el rango 1 a 6. Posición:[" + Convert.ToString(y + 1) + "]");
                            }
                            break;
                        case 6: //DestinatarioDocumento
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 11);
                            IsNumber(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            break;
                        case 7: //DestinatarioNombre
                            if (String.IsNullOrEmpty(Convert.ToString(dt.Rows[y][i])))
                            {
                                Convert.ToString(dt.Rows[y][i] = "");
                            }
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 50);
                            break;
                        case 8: //DestinatarioApellido
                            if (String.IsNullOrEmpty(Convert.ToString(dt.Rows[y][i])))
                            {
                                Convert.ToString(dt.Rows[y][i] = "");
                            }
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 50);
                            break;
                        case 9: //DestinatarioDomicilio
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 100);
                            break;
                        case 10: //DestinatarioCodigoPostal
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 0);
                            IsNumber(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            break;
                        case 11: //DestinatarioTeLinea
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 10);
                            IsNumber(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            break;
                        case 12: //DestinatarioTelCelular
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 10);
                            IsNumber(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            break;
                        case 13: //DestinatarioEmail
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 0);
                            if (!EmailIsValid(Convert.ToString(dt.Rows[y][i])))
                            {
                                AddLog(dt.Columns[i].ColumnName+ ": Formato incorrecto. Posición:[" + Convert.ToString(y + 1) + "]");
                            }
                            break;
                        case 14: //FechaEntrega
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 0);
                            IsDate(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            if (DateTime.Parse(Convert.ToString(dt.Rows[y][i])) < DateTime.Now)
                            {
                                AddLog(dt.Columns[i].ColumnName + ": No puede ser menor a la actual. Posición: [" + Convert.ToString(y + 1) + "]");
                            }
                            break;
                        case 16: //FechaRetiro
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 0);
                            IsDate(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            break;
                        case 17: //DomicilioRetiroCliente
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 100);
                            break;
                        case 18: //ClienteCodigoPostalRetiro
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 0);
                            break;
                        case 19: //CantidadBultos
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 0);
                            IsNumber(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            break;
                        case 20: //BultoTipo
                            StringLenght(Convert.ToInt16(Convert.ToString(dt.Rows[y][i]).Length), dt.Columns[i].ColumnName, Convert.ToString(y + 1), 0);
                            break;
                        case 21: //Peso
                            IsNumber(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            break;
                        case 22: //AltoCm
                            IsNumber(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            break;
                        case 23: //AnchoCm
                            IsNumber(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            break;
                        case 24: //LargoCm
                            IsNumber(Convert.ToString(dt.Rows[y][i]), dt.Columns[i].ColumnName, Convert.ToString(y + 1));
                            break;
                    }
                }
            }
            if (CountErrores == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void IsDate(String fecha, String columna, String fila)
        {
            try
            {
                DateTime.Parse(fecha);
            }
            catch
            {
                AddLog(columna + ": Formato inválido. Posición: [" + fila + "].");
            }
        }
        private void IsNumber(String num, String columna, String fila)
        {
            try
            {
                Int64.Parse(num);
            }
            catch
            {
                AddLog(columna + ": Debe ser numérico. Posición:[" + fila + "]");
            }
        }
        private void IsString(String letra, String columna, String fila)
        {
            try
            {
                Int64.Parse(letra);
                AddLog(columna + ": Debe ser alfabético. Posición:[" + fila + "]");
            }
            catch
            {
            }
        }
        private void StringLenght(Int16 lenght, String columna, String fila, Int16 num)
        {
            if (lenght == 0)
            {
                AddLog(columna + ": No se completó el campo. Posición:[" + fila + "]");
            }
            if (num > 0)
            {
                if (lenght > num)
                {
                    AddLog(columna + ": Se excedió la cantidad de digitos. Posición:[" + fila + "]");
                }
            }
        }
        private void AddLog(string message)
        {
            log log = new log();
            log.Add(message);
            CountErrores++;
        }
        private static bool EmailIsValid(string email)
        {
            string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expression))
            {
                if (Regex.Replace(email, expression, string.Empty).Length == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}