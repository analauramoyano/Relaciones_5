﻿namespace Relaciones_5
{
    partial class FormularioLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grillaLibro = new System.Windows.Forms.DataGridView();
            this.btn_alta_libro = new System.Windows.Forms.Button();
            this.btn_baja_libro = new System.Windows.Forms.Button();
            this.btn_modificacion_libro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_isbn_libro = new System.Windows.Forms.TextBox();
            this.txt_titulo_libro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaLibro
            // 
            this.grillaLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaLibro.Location = new System.Drawing.Point(67, 53);
            this.grillaLibro.MultiSelect = false;
            this.grillaLibro.Name = "grillaLibro";
            this.grillaLibro.ReadOnly = true;
            this.grillaLibro.RowTemplate.Height = 24;
            this.grillaLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaLibro.Size = new System.Drawing.Size(658, 167);
            this.grillaLibro.TabIndex = 0;
            // 
            // btn_alta_libro
            // 
            this.btn_alta_libro.Location = new System.Drawing.Point(48, 281);
            this.btn_alta_libro.Name = "btn_alta_libro";
            this.btn_alta_libro.Size = new System.Drawing.Size(75, 23);
            this.btn_alta_libro.TabIndex = 1;
            this.btn_alta_libro.Text = "Alta";
            this.btn_alta_libro.UseVisualStyleBackColor = true;
            // 
            // btn_baja_libro
            // 
            this.btn_baja_libro.Location = new System.Drawing.Point(348, 281);
            this.btn_baja_libro.Name = "btn_baja_libro";
            this.btn_baja_libro.Size = new System.Drawing.Size(75, 23);
            this.btn_baja_libro.TabIndex = 2;
            this.btn_baja_libro.Text = "Baja";
            this.btn_baja_libro.UseVisualStyleBackColor = true;
            // 
            // btn_modificacion_libro
            // 
            this.btn_modificacion_libro.Location = new System.Drawing.Point(650, 281);
            this.btn_modificacion_libro.Name = "btn_modificacion_libro";
            this.btn_modificacion_libro.Size = new System.Drawing.Size(120, 23);
            this.btn_modificacion_libro.TabIndex = 3;
            this.btn_modificacion_libro.Text = "Modificación";
            this.btn_modificacion_libro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Isbn";
            // 
            // txt_isbn_libro
            // 
            this.txt_isbn_libro.Location = new System.Drawing.Point(132, 371);
            this.txt_isbn_libro.Name = "txt_isbn_libro";
            this.txt_isbn_libro.Size = new System.Drawing.Size(229, 22);
            this.txt_isbn_libro.TabIndex = 5;
            // 
            // txt_titulo_libro
            // 
            this.txt_titulo_libro.Location = new System.Drawing.Point(496, 371);
            this.txt_titulo_libro.Name = "txt_titulo_libro";
            this.txt_titulo_libro.Size = new System.Drawing.Size(229, 22);
            this.txt_titulo_libro.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Título";
            // 
            // FormularioLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_titulo_libro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_isbn_libro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modificacion_libro);
            this.Controls.Add(this.btn_baja_libro);
            this.Controls.Add(this.btn_alta_libro);
            this.Controls.Add(this.grillaLibro);
            this.Name = "FormularioLibro";
            this.Text = "FormularioLibro";
            ((System.ComponentModel.ISupportInitialize)(this.grillaLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaLibro;
        private System.Windows.Forms.Button btn_alta_libro;
        private System.Windows.Forms.Button btn_baja_libro;
        private System.Windows.Forms.Button btn_modificacion_libro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_isbn_libro;
        private System.Windows.Forms.TextBox txt_titulo_libro;
        private System.Windows.Forms.Label label2;
    }
}