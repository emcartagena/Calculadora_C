namespace Calculadora
{
    partial class Fcalculadora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBpantalla = new System.Windows.Forms.TextBox();
            this.bPorcentaje = new System.Windows.Forms.Button();
            this.bBorrarTodo = new System.Windows.Forms.Button();
            this.bRetro = new System.Windows.Forms.Button();
            this.bSiete = new System.Windows.Forms.Button();
            this.bOcho = new System.Windows.Forms.Button();
            this.bNueve = new System.Windows.Forms.Button();
            this.bCuatro = new System.Windows.Forms.Button();
            this.bCinco = new System.Windows.Forms.Button();
            this.bSeis = new System.Windows.Forms.Button();
            this.bUno = new System.Windows.Forms.Button();
            this.bDos = new System.Windows.Forms.Button();
            this.bTres = new System.Windows.Forms.Button();
            this.bSigno = new System.Windows.Forms.Button();
            this.bCero = new System.Windows.Forms.Button();
            this.bIgual = new System.Windows.Forms.Button();
            this.bSumar = new System.Windows.Forms.Button();
            this.bRestar = new System.Windows.Forms.Button();
            this.bDivision = new System.Windows.Forms.Button();
            this.bMultiplicacion = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.bRaizC = new System.Windows.Forms.Button();
            this.bCuadrado = new System.Windows.Forms.Button();
            this.bPunto = new System.Windows.Forms.Button();
            this.bDivideX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBpantalla
            // 
            this.tBpantalla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tBpantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBpantalla.Location = new System.Drawing.Point(12, 12);
            this.tBpantalla.MaxLength = 26;
            this.tBpantalla.Multiline = true;
            this.tBpantalla.Name = "tBpantalla";
            this.tBpantalla.ReadOnly = true;
            this.tBpantalla.Size = new System.Drawing.Size(399, 40);
            this.tBpantalla.TabIndex = 0;
            this.tBpantalla.Text = "0";
            this.tBpantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bPorcentaje
            // 
            this.bPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPorcentaje.Location = new System.Drawing.Point(336, 58);
            this.bPorcentaje.Name = "bPorcentaje";
            this.bPorcentaje.Size = new System.Drawing.Size(75, 40);
            this.bPorcentaje.TabIndex = 1;
            this.bPorcentaje.Text = "%";
            this.bPorcentaje.UseVisualStyleBackColor = true;
            this.bPorcentaje.Click += new System.EventHandler(this.Click_Operador);
            // 
            // bBorrarTodo
            // 
            this.bBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrarTodo.Location = new System.Drawing.Point(12, 58);
            this.bBorrarTodo.Name = "bBorrarTodo";
            this.bBorrarTodo.Size = new System.Drawing.Size(75, 40);
            this.bBorrarTodo.TabIndex = 2;
            this.bBorrarTodo.Text = "C";
            this.bBorrarTodo.UseVisualStyleBackColor = true;
            this.bBorrarTodo.Click += new System.EventHandler(this.bBorrarTodo_Click);
            // 
            // bRetro
            // 
            this.bRetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRetro.Location = new System.Drawing.Point(174, 58);
            this.bRetro.Name = "bRetro";
            this.bRetro.Size = new System.Drawing.Size(75, 40);
            this.bRetro.TabIndex = 3;
            this.bRetro.Text = "←";
            this.bRetro.UseVisualStyleBackColor = true;
            this.bRetro.Click += new System.EventHandler(this.bRetro_Click);
            // 
            // bSiete
            // 
            this.bSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSiete.Location = new System.Drawing.Point(12, 104);
            this.bSiete.Name = "bSiete";
            this.bSiete.Size = new System.Drawing.Size(75, 40);
            this.bSiete.TabIndex = 4;
            this.bSiete.Text = "7";
            this.bSiete.UseVisualStyleBackColor = true;
            this.bSiete.Click += new System.EventHandler(this.agregar_numero);
            // 
            // bOcho
            // 
            this.bOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOcho.Location = new System.Drawing.Point(93, 104);
            this.bOcho.Name = "bOcho";
            this.bOcho.Size = new System.Drawing.Size(75, 40);
            this.bOcho.TabIndex = 5;
            this.bOcho.Text = "8";
            this.bOcho.UseVisualStyleBackColor = true;
            this.bOcho.Click += new System.EventHandler(this.agregar_numero);
            // 
            // bNueve
            // 
            this.bNueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNueve.Location = new System.Drawing.Point(174, 104);
            this.bNueve.Name = "bNueve";
            this.bNueve.Size = new System.Drawing.Size(75, 40);
            this.bNueve.TabIndex = 6;
            this.bNueve.Text = "9";
            this.bNueve.UseVisualStyleBackColor = true;
            this.bNueve.Click += new System.EventHandler(this.agregar_numero);
            // 
            // bCuatro
            // 
            this.bCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCuatro.Location = new System.Drawing.Point(12, 150);
            this.bCuatro.Name = "bCuatro";
            this.bCuatro.Size = new System.Drawing.Size(75, 40);
            this.bCuatro.TabIndex = 7;
            this.bCuatro.Text = "4";
            this.bCuatro.UseVisualStyleBackColor = true;
            this.bCuatro.Click += new System.EventHandler(this.agregar_numero);
            // 
            // bCinco
            // 
            this.bCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCinco.Location = new System.Drawing.Point(93, 150);
            this.bCinco.Name = "bCinco";
            this.bCinco.Size = new System.Drawing.Size(75, 40);
            this.bCinco.TabIndex = 8;
            this.bCinco.Text = "5";
            this.bCinco.UseVisualStyleBackColor = true;
            this.bCinco.Click += new System.EventHandler(this.agregar_numero);
            // 
            // bSeis
            // 
            this.bSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeis.Location = new System.Drawing.Point(174, 150);
            this.bSeis.Name = "bSeis";
            this.bSeis.Size = new System.Drawing.Size(75, 40);
            this.bSeis.TabIndex = 9;
            this.bSeis.Text = "6";
            this.bSeis.UseVisualStyleBackColor = true;
            this.bSeis.Click += new System.EventHandler(this.agregar_numero);
            // 
            // bUno
            // 
            this.bUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUno.Location = new System.Drawing.Point(12, 196);
            this.bUno.Name = "bUno";
            this.bUno.Size = new System.Drawing.Size(75, 40);
            this.bUno.TabIndex = 10;
            this.bUno.Text = "1";
            this.bUno.UseVisualStyleBackColor = true;
            this.bUno.Click += new System.EventHandler(this.agregar_numero);
            // 
            // bDos
            // 
            this.bDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDos.Location = new System.Drawing.Point(93, 196);
            this.bDos.Name = "bDos";
            this.bDos.Size = new System.Drawing.Size(75, 40);
            this.bDos.TabIndex = 11;
            this.bDos.Text = "2";
            this.bDos.UseVisualStyleBackColor = true;
            this.bDos.Click += new System.EventHandler(this.agregar_numero);
            // 
            // bTres
            // 
            this.bTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTres.Location = new System.Drawing.Point(174, 196);
            this.bTres.Name = "bTres";
            this.bTres.Size = new System.Drawing.Size(75, 40);
            this.bTres.TabIndex = 12;
            this.bTres.Text = "3";
            this.bTres.UseVisualStyleBackColor = true;
            this.bTres.Click += new System.EventHandler(this.agregar_numero);
            // 
            // bSigno
            // 
            this.bSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSigno.Location = new System.Drawing.Point(12, 242);
            this.bSigno.Name = "bSigno";
            this.bSigno.Size = new System.Drawing.Size(75, 40);
            this.bSigno.TabIndex = 13;
            this.bSigno.Text = "+/-";
            this.bSigno.UseVisualStyleBackColor = true;
            this.bSigno.Click += new System.EventHandler(this.bSigno_Click);
            // 
            // bCero
            // 
            this.bCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCero.Location = new System.Drawing.Point(93, 242);
            this.bCero.Name = "bCero";
            this.bCero.Size = new System.Drawing.Size(75, 40);
            this.bCero.TabIndex = 14;
            this.bCero.Text = "0";
            this.bCero.UseVisualStyleBackColor = true;
            this.bCero.Click += new System.EventHandler(this.agregar_numero);
            // 
            // bIgual
            // 
            this.bIgual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIgual.Location = new System.Drawing.Point(255, 242);
            this.bIgual.Name = "bIgual";
            this.bIgual.Size = new System.Drawing.Size(156, 40);
            this.bIgual.TabIndex = 16;
            this.bIgual.Text = "=";
            this.bIgual.UseVisualStyleBackColor = false;
            this.bIgual.Click += new System.EventHandler(this.bIgual_Click);
            // 
            // bSumar
            // 
            this.bSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSumar.Location = new System.Drawing.Point(255, 196);
            this.bSumar.Name = "bSumar";
            this.bSumar.Size = new System.Drawing.Size(75, 40);
            this.bSumar.TabIndex = 17;
            this.bSumar.Text = "+";
            this.bSumar.UseVisualStyleBackColor = true;
            this.bSumar.Click += new System.EventHandler(this.Click_Operador);
            // 
            // bRestar
            // 
            this.bRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRestar.Location = new System.Drawing.Point(255, 150);
            this.bRestar.Name = "bRestar";
            this.bRestar.Size = new System.Drawing.Size(75, 40);
            this.bRestar.TabIndex = 18;
            this.bRestar.Text = "-";
            this.bRestar.UseVisualStyleBackColor = true;
            this.bRestar.Click += new System.EventHandler(this.Click_Operador);
            // 
            // bDivision
            // 
            this.bDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDivision.Location = new System.Drawing.Point(255, 104);
            this.bDivision.Name = "bDivision";
            this.bDivision.Size = new System.Drawing.Size(75, 40);
            this.bDivision.TabIndex = 21;
            this.bDivision.Text = "/";
            this.bDivision.UseVisualStyleBackColor = true;
            this.bDivision.Click += new System.EventHandler(this.Click_Operador);
            // 
            // bMultiplicacion
            // 
            this.bMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMultiplicacion.Location = new System.Drawing.Point(255, 58);
            this.bMultiplicacion.Name = "bMultiplicacion";
            this.bMultiplicacion.Size = new System.Drawing.Size(75, 40);
            this.bMultiplicacion.TabIndex = 22;
            this.bMultiplicacion.Text = "*";
            this.bMultiplicacion.UseVisualStyleBackColor = true;
            this.bMultiplicacion.Click += new System.EventHandler(this.Click_Operador);
            // 
            // bBorrar
            // 
            this.bBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(93, 58);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(75, 40);
            this.bBorrar.TabIndex = 23;
            this.bBorrar.Text = "CE";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // bRaizC
            // 
            this.bRaizC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRaizC.Location = new System.Drawing.Point(336, 104);
            this.bRaizC.Name = "bRaizC";
            this.bRaizC.Size = new System.Drawing.Size(75, 40);
            this.bRaizC.TabIndex = 24;
            this.bRaizC.Tag = "√";
            this.bRaizC.Text = "√²";
            this.bRaizC.UseVisualStyleBackColor = true;
            this.bRaizC.Click += new System.EventHandler(this.bRaizC_Click);
            // 
            // bCuadrado
            // 
            this.bCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCuadrado.Location = new System.Drawing.Point(336, 150);
            this.bCuadrado.Name = "bCuadrado";
            this.bCuadrado.Size = new System.Drawing.Size(75, 40);
            this.bCuadrado.TabIndex = 25;
            this.bCuadrado.Tag = "²";
            this.bCuadrado.Text = "x²";
            this.bCuadrado.UseVisualStyleBackColor = true;
            this.bCuadrado.Click += new System.EventHandler(this.bCuadrado_Click);
            // 
            // bPunto
            // 
            this.bPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPunto.Location = new System.Drawing.Point(174, 242);
            this.bPunto.Name = "bPunto";
            this.bPunto.Size = new System.Drawing.Size(75, 40);
            this.bPunto.TabIndex = 26;
            this.bPunto.Text = ".";
            this.bPunto.UseVisualStyleBackColor = true;
            // 
            // bDivideX
            // 
            this.bDivideX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDivideX.Location = new System.Drawing.Point(336, 196);
            this.bDivideX.Name = "bDivideX";
            this.bDivideX.Size = new System.Drawing.Size(75, 40);
            this.bDivideX.TabIndex = 27;
            this.bDivideX.Tag = "¹";
            this.bDivideX.Text = "¹/";
            this.bDivideX.UseVisualStyleBackColor = true;
            this.bDivideX.Click += new System.EventHandler(this.bDivideX_Click);
            // 
            // Fcalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 291);
            this.Controls.Add(this.bDivideX);
            this.Controls.Add(this.bPunto);
            this.Controls.Add(this.bCuadrado);
            this.Controls.Add(this.bRaizC);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bMultiplicacion);
            this.Controls.Add(this.bDivision);
            this.Controls.Add(this.bRestar);
            this.Controls.Add(this.bSumar);
            this.Controls.Add(this.bIgual);
            this.Controls.Add(this.bCero);
            this.Controls.Add(this.bSigno);
            this.Controls.Add(this.bTres);
            this.Controls.Add(this.bDos);
            this.Controls.Add(this.bUno);
            this.Controls.Add(this.bSeis);
            this.Controls.Add(this.bCinco);
            this.Controls.Add(this.bCuatro);
            this.Controls.Add(this.bNueve);
            this.Controls.Add(this.bOcho);
            this.Controls.Add(this.bSiete);
            this.Controls.Add(this.bRetro);
            this.Controls.Add(this.bBorrarTodo);
            this.Controls.Add(this.bPorcentaje);
            this.Controls.Add(this.tBpantalla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Fcalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBpantalla;
        private System.Windows.Forms.Button bPorcentaje;
        private System.Windows.Forms.Button bBorrarTodo;
        private System.Windows.Forms.Button bRetro;
        private System.Windows.Forms.Button bSiete;
        private System.Windows.Forms.Button bOcho;
        private System.Windows.Forms.Button bNueve;
        private System.Windows.Forms.Button bCuatro;
        private System.Windows.Forms.Button bCinco;
        private System.Windows.Forms.Button bSeis;
        private System.Windows.Forms.Button bUno;
        private System.Windows.Forms.Button bDos;
        private System.Windows.Forms.Button bTres;
        private System.Windows.Forms.Button bSigno;
        private System.Windows.Forms.Button bCero;
        private System.Windows.Forms.Button bIgual;
        private System.Windows.Forms.Button bSumar;
        private System.Windows.Forms.Button bRestar;
        private System.Windows.Forms.Button bDivision;
        private System.Windows.Forms.Button bMultiplicacion;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.Button bRaizC;
        private System.Windows.Forms.Button bCuadrado;
        private System.Windows.Forms.Button bPunto;
        private System.Windows.Forms.Button bDivideX;
    }
}

