using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Nomina.ModeloDeDatos
{
    public class ValidarCampo
    {
        public static void charSoloLetras(TextBox txt, KeyPressEventArgs valor, Label lblError, ErrorProvider ep)
        {
            if (!string.IsNullOrEmpty(txt.Text)) // Si el TextBox contiene texto
            {
                if (char.IsLetter(valor.KeyChar))
                {
                    valor.Handled = false;
                }
                else if (char.IsSeparator(valor.KeyChar))
                {
                    valor.Handled = false;
                }
                else if (char.IsControl(valor.KeyChar))
                {
                    valor.Handled = false;
                }
                else
                {
                    valor.Handled = true;
                    //Mostrar Label debajo del campo con texto de error en rojo y el Error Provider
                    lblError.Visible = true;
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Recuerda que debes ingresar solamente letras";
                    ep.Icon = SystemIcons.Error;
                    ep.SetError(txt, "Solo se admiten Letras");
                }
            }
            else //Si el TextBox esta vacio, y quedo visualizando la ultima advertencia...
            {
                //Se limpia el label de error y el Error Provider cuando se ingrese texto      
                lblError.Visible = false;
                ep.Clear();

            }


        }


        public static void charSoloNumeros(TextBox txt, KeyPressEventArgs valor, Label lblError, ErrorProvider ep)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (char.IsNumber(valor.KeyChar))
                {
                    valor.Handled = false;
                }
                else if (char.IsSeparator(valor.KeyChar))
                {
                    valor.Handled = false;
                }
                else if (char.IsControl(valor.KeyChar)) //Condicion que nos permite utilizar la tecla Backspace
                {
                    valor.Handled = false;
                }
                else if (valor.KeyChar.ToString().Equals("."))
                {
                    valor.Handled = false;
                }
                else
                {
                    valor.Handled = true;
                    //Mostrar Label debajo del campo con texto de error en rojo y el Error Provider
                    lblError.Visible = true;
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Recuerda que debes ingresar solamente numeros";
                    ep.Icon = SystemIcons.Error;
                    ep.SetError(txt, "Solo se admiten Numeros");
                    txt.Clear();

                }
            }
            else
            {
                //Se limpia el label de error y el Error Provider cuando se ingrese texto      
                lblError.Visible = false;
                ep.Clear();

            }

        }
        public static void charSoloNumerosDecimal(TextBox txt, KeyPressEventArgs valor, Label lblError, ErrorProvider ep)
        {

            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (char.IsDigit(valor.KeyChar))
                {
                    valor.Handled = false;
                }
                else if (char.IsSeparator(valor.KeyChar))
                {
                    valor.Handled = false;
                }
                else if (char.IsControl(valor.KeyChar))
                {
                    valor.Handled = false;
                }
                else if (valor.KeyChar.ToString().Equals("."))
                {
                    valor.Handled = false;
                }
                else //Si el TextBox esta vacio, y quedo visualizando la ultima advertencia..
                {
                    valor.Handled = true;
                    //Mostrar Label debajo del campo con texto de error en rojo y el Error Provider
                    lblError.Visible = true;
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Recuerda que debes ingresar solamente numeros decimales";
                    ep.Icon = SystemIcons.Error;
                    ep.SetError(txt, "Solo se admiten Numeros decimales");
                }
            }
            else //Si el TextBox esta vacio, y quedo visualizando la ultima advertencia...
            {
                //Se limpia el label de error y el Error Provider cuando se ingrese texto      
                lblError.Visible = false;
                ep.Clear();

            }


        }

        //Terminado:
        public static void soloLetrasPermitirNumeros(TextBox txt, bool EsCampoObligatorio, Label lblError, ErrorProvider ep, int charPermitidos)
        {
            lblError.Text = string.Empty; //Si el label tenia un texto a la hora de iniciar el Form, se limpia
            lblError.AutoSize = true; //Ajusta el texto del label segun el texto ingresado
            lblError.AutoEllipsis = true;
            lblError.Visible = false; // El label de error esta invisible hasta que se detecta un error   
            bool error = false;

            if (!string.IsNullOrEmpty(txt.Text)) //Si el TextBox enviado no esta vacio o con valores nulos
            {

                //Recorreremos todos los caracteres en el texto que contiene el textBox
                foreach (char caracter in txt.Text)
                {
                    // Si es letra, no habra error
                    if (char.IsLetter(caracter))
                    {
                        error = false;
                    }
                    if (char.IsLetter(caracter) && char.IsDigit(caracter)) // Si hay numeros y letras en el texto, no habra error
                    {
                        error = false;
                    }
                    if (char.IsDigit(caracter)) // Si solo hay numeros el el texto, habra error
                    {
                        error = true;
                        //Se inicializara y se mostrara el error provider y el label de error
                        ep.Icon = SystemIcons.Exclamation;
                        ep.SetError(txt, "**Solo se admiten Letras, o combinaciones de letras con numeros.**");
                        lblError.Visible = true;
                        lblError.Text = "No olvides que no puedes ingresar solamente numeros";
                        lblError.ForeColor = System.Drawing.Color.OrangeRed;
                    }
                    //Verificamos la condicion de error, y si no hay error pero anteriormente habia un error,
                    //se limpia el ErrorProvider y se oculta el Label de Error
                    if (error == false)
                    {
                        lblError.Visible = false;
                        error = false;
                        ep.Clear();

                        lblError.Visible = true;
                        lblError.Text = " Caracteres ingresados: (" + txt.TextLength + "/" + charPermitidos + ")";

                        //Si la longitud del texto es mayor que la cantidad de caracteres permitidos, y los caracteres permitidos son mayores a 0
                        if (txt.TextLength > charPermitidos && charPermitidos > 0)
                        {
                            //Notifico al usuario que hay un error en la cantidad de caracteres digitados
                            lblError.ForeColor = Color.Red;
                            lblError.Text = lblError.Text + ". Estas excediendo el numero de caracteres permitidos";
                        }
                        else
                        {
                            lblError.ForeColor = Color.Green;
                        }
                        break;
                    }
                    else //Si hay un error quiere decir que el usuario esta ingresando solo numeros y la variable error es verdadera
                    {
                        lblError.ForeColor = System.Drawing.Color.BlueViolet;
                        lblError.Text += ". Caracteres ingresados: (" + txt.TextLength + "/" + charPermitidos + ")";

                        if (txt.TextLength > charPermitidos && charPermitidos > 0) //Si el usuario excedio el numero de caracteres permitidos
                        {
                            //Notifico al usuario que hay un error en la cantidad de caracteres digitados y que esta ingresando solo numeros
                            ep.Icon = SystemIcons.Error;
                            ep.SetError(txt, "**No se admiten solo numeros.**" + Environment.NewLine
                                + "Este campo solo permite letras, o combinaciones de letras con numeros." + Environment.NewLine + Environment.NewLine
                                + "** Solo se permiten " + charPermitidos + " caracteres en este campo.**" + Environment.NewLine
                                + "Para corregir el error verifica que no estes excediendo el numero de caracteres permitidos."
                                );
                            lblError.ForeColor = Color.Red;
                            lblError.Text = "Caracteres ingresados: (" + txt.TextLength + "/" + charPermitidos + "). No se admiten solo numeros.";
                        }
                    }

                }

            }
            else //Si el TextBox esta vacio 
            {
                //Confirmame si el campo es Obligatorio
                if (EsCampoObligatorio == true) //Si es Obligatorio, muestrame la Advertencia para que no se quede vacio
                {
                    //Mostrar Error Provider y label con texto de error rojo que diga que es campo obligatorio
                    ep.Icon = SystemIcons.Error;
                    ep.SetError(txt, "**Campo Obligatorio**");
                    lblError.Visible = true;
                    lblError.Text = "No puedes dejar este campo vacio. Es un campo Obligatorio";
                    lblError.ForeColor = System.Drawing.Color.Red;
                }
                else //Si el campo no es obligatorio, verifico que no haya error con la entrada de datos
                {
                    //Verificamos por la condicion de error el texto que se ingreso
                    if (error == false) // Si anteriormente habia un error de entrada de datos y se corrigio, entonces...
                    {
                        lblError.Visible = false; //Ocultamos el Label de Error con la Advertencia anterior
                        error = false;
                        ep.Clear(); //Limpiamos o Quitamos la aparicion del ErrorProvider

                    }
                }

            }


        }

        //Terminado:
        public static void soloLetras(TextBox txt, bool EsCampoObligatorio, Label lblError, ErrorProvider ep, int charPermitidos)
        {
            lblError.Text = string.Empty; //Si el label tenia un texto a la hora de iniciar el Form, se limpia
            lblError.AutoSize = true; //Ajusta el texto del label segun el texto ingresado
            lblError.AutoEllipsis = true;
            lblError.Visible = false; // El label de error esta invisible hasta que se detecta un error
            bool error = false;

            if (!string.IsNullOrEmpty(txt.Text)) //Si el TextBox enviado no esta vacio o con valores nulos
            {
                //Recorreremos todos los caracteres en el texto que contiene el textBox
                foreach (char caracter in txt.Text)
                {
                    // Si es letra, no habra error
                    if (char.IsLetter(caracter))
                    {
                        error = false;
                    }

                    if (char.IsDigit(caracter)) // Si solo hay numeros en el texto, habra error
                    {
                        error = true;
                        //Se inicializara y se mostrara el error provider y el label de error
                        ep.Icon = SystemIcons.Exclamation;
                        ep.SetError(txt, "Solo se admiten Letras");
                        lblError.Visible = true;
                        lblError.Text = "No olvides que solamente debes ingresar letras en este campo";
                        lblError.ForeColor = System.Drawing.Color.Orange;
                        break;

                    }
                    //Verificamos la condicion de error, y si no hay error pero anteriormente habia un error,
                    //se limpia el ErrorProvider y se oculta el Label de Error
                    if (error == false)
                    {
                        lblError.Visible = false;
                        error = false;
                        ep.Clear();

                        if (charPermitidos > 0)
                        {
                            lblError.Visible = true;
                            lblError.Text = " Caracteres ingresados: (" + txt.TextLength + "/" + charPermitidos + ")";

                            //Si la longitud del texto es mayor que la cantidad de caracteres permitidos, y los caracteres permitidos son mayores a 0
                            if (txt.TextLength > charPermitidos && charPermitidos > 0)
                            {
                                lblError.ForeColor = Color.Red;
                                lblError.Text = lblError.Text + ". Estas excediendo el numero de caracteres permitidos";
                            }
                            else
                            {
                                lblError.ForeColor = Color.Green;
                            }
                        }
                        break;
                    }

                }

            }
            else //Si el TextBox esta vacio 
            {
                //Confirmame si el campo es Obligatorio
                if (EsCampoObligatorio == true) //Si es Obligatorio, muestrame la Advertencia para que no se quede vacio
                {
                    //Mostrar Error Provider y label con texto de error rojo que diga que es campo obligatorio
                    ep.Icon = SystemIcons.Error;
                    ep.SetError(txt, "**Campo Obligatorio**");
                    lblError.Visible = true;
                    lblError.Text = "No puedes dejar este campo vacio. Es un campo Obligatorio";
                    lblError.ForeColor = System.Drawing.Color.Red;
                }
                else //Si el campo no es obligatorio, verifico que no haya error con la entrada de datos
                {
                    //Verificamos por la condicion de error
                    if (error == false) // Si anteriormente habia un error de entrada de datos y se corrigio, entonces...
                    {
                        lblError.Visible = false; //Ocultamos el Label de Error con la Advertencia anterior
                        error = false;
                        ep.Clear(); //Limpiamos o Quitamos la aparicion del ErrorProvider

                    }
                }

            }


        }

        public static void soloNumeros(TextBox txt ,KeyPressEventArgs valor, bool EsCampoObligatorio, Label lblError, ErrorProvider ep, int charPermitidos)
        {
            lblError.Text = string.Empty; //Si el label tenia un texto a la hora de iniciar el Form, se limpia
            lblError.AutoSize = true; //Ajusta el texto del label segun el texto ingresado
            lblError.AutoEllipsis = true;
            lblError.Visible = false; // El label de error esta invisible hasta que se detecta un error
            bool error = false;

            if (!string.IsNullOrEmpty(txt.Text)) //Si el TextBox enviado no esta vacio o con valores nulos
            {
                //Recorreremos todos los caracteres en el texto que contiene el textBox
                if (char.IsLetter(valor.KeyChar))
                {
                    valor.Handled = true;
                }
                if (char.IsDigit(valor.KeyChar))
                {


                    foreach (char caracter in txt.Text)
                    {
                        // Si es letra, no habra error
                        if (char.IsDigit(caracter) || char.IsControl(caracter))
                        {
                            error = false;
                            lblError.Visible = true;
                            lblError.Text = " Caracteres ingresados: (" + (txt.TextLength + 1) + "/" + charPermitidos + ")";

                            //Si la longitud del texto es mayor que la cantidad de caracteres permitidos, y los caracteres permitidos son mayores a 0
                            if (txt.TextLength + 1 > charPermitidos && charPermitidos > 0)
                            {
                                lblError.ForeColor = Color.Red;
                                lblError.Text = lblError.Text + ". Estas excediendo el numero de caracteres permitidos";
                            }
                            else if (txt.TextLength + 1 == charPermitidos)
                            {
                                lblError.ForeColor = Color.Green;

                            }
                        }
                        else

                        {
                            error = false;
                            //Se inicializara y se mostrara el error provider y el label de error
                            ep.Icon = SystemIcons.Exclamation;
                            ep.SetError(txt, "Solo se admiten numeros");
                            lblError.Visible = true;
                            lblError.Text = "No olvides que solamente debes ingresar numeros en este campo";
                            lblError.ForeColor = System.Drawing.Color.Orange;
                            break;

                        }

                    }
                }
            }
            else //Si el TextBox esta vacio 
            {
                //Confirmame si el campo es Obligatorio
                if (EsCampoObligatorio == true) //Si es Obligatorio, muestrame la Advertencia para que no se quede vacio
                {
                    //Mostrar Error Provider y label con texto de error rojo que diga que es campo obligatorio
                    ep.Icon = SystemIcons.Error;
                    ep.SetError(txt, "**Campo Obligatorio**");
                    lblError.Visible = true;
                    lblError.Text = "No puedes dejar este campo vacio. Es un campo Obligatorio";
                    lblError.ForeColor = System.Drawing.Color.Red;
                }
                else //Si el campo no es obligatorio, verifico que no haya error con la entrada de datos
                {
                    //Verificamos por la condicion de error
                    if (error == false) // Si anteriormente habia un error de entrada de datos y se corrigio, entonces...
                    {
                        lblError.Visible = false; //Ocultamos el Label de Error con la Advertencia anterior
                        error = false;
                        ep.Clear(); //Limpiamos o Quitamos la aparicion del ErrorProvider

                    }
                }

            }


        }

        public static void soloNumerosDecimales(TextBox txt, KeyPressEventArgs e,ErrorProvider ep)
        {
          //  TextBox txt = (TextBox)sender;
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back
                            || (e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator))
                        || ((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                            && txt.Text.Contains('.'));
        }
        //public static void soloLetras(TextBox txt, bool EsCampoObligatorio, Label lblError, ErrorProvider ep, int charPermitidos)

        public static bool validarEmail(string txt)
        {
            return Regex.IsMatch(txt.ToString(), @"\A(?:[a-z0-9!#$%&'+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'+/=?^_`{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
         

                

        }
        public static void charSoloNumerosEnteros(TextBox txt, KeyPressEventArgs valor, Label lblError, ErrorProvider ep)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (char.IsNumber(valor.KeyChar))
                {
                    valor.Handled = false;
                }
            
                else if (char.IsControl(valor.KeyChar)) //Condicion que nos permite utilizar la tecla Backspace
                {
                    valor.Handled = false;
                }
                else
                {
                    valor.Handled = true;
                    //Mostrar Label debajo del campo con texto de error en rojo y el Error Provider
                    lblError.Visible = true;
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Recuerda que debes ingresar solamente numeros";
                    ep.Icon = SystemIcons.Error;
                    ep.SetError(txt, "Solo se admiten Numeros");
                    txt.Clear();

                }
            }
            else
            {
                //Se limpia el label de error y el Error Provider cuando se ingrese texto      
                lblError.Visible = false;
                ep.Clear();

            }

        }

        //El siguiente metodo es para utilizarse a la hora de procesar un formulario completo
        //public static void soloLetrasYNumeros(TextBox valorTxt)
        //{
        //    for (int i = 0; i < txt.Text.Length; i++)
        //    {

        //    }
        //    if (valor.KeyChar == Convert.ToChar(Keys.Back))
        //    {

        //    }

        // //Si la longitud del texto es mayor que la cantidad de caracteres permitidos, y los caracteres permitidos son mayores a 0
        //        if (txt.TextLength > charPermitidos && charPermitidos > 0)
        //        {
        //            //Notifico al usuario que hay un error en la cantidad de caracteres digitados
        //            //MessageBox.Show("Superaste los caracteres permitidos. Solo se admiten "
        //            //    + charPermitidos + " carateres en este campo", "Error ",
        //            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            //txt.Clear();

        //        }


        //    if (char.IsLetter(Convert.ToChar(valorTxt.Text)) && char.IsNumber(Convert.ToChar(valorTxt.Text)))
        //    {
        //        valorTxt.Handled = false;
        //    }
        //    else if (char.IsSeparator(Convert.ToChar(valorTxt.Text)))
        //    {
        //        valor.Handled = false;
        //    }
        //    else if (char.IsControl(Convert.ToChar(valorTxt.Text)))
        //    {
        //        valor.Handled = false;
        //    }
        //    else
        //    {
        //        valor.Handled = true;
        //        MessageBox.Show("Solo se admiten Letras combinadas con numeros");
        //    }
        //}


        public static void validarFechaActividad()
        {

        }

        public static void validarFechaTarea()
        {

        }

        public static void validarFechaSubTarea()
        {

        }

    }

}
