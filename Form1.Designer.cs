namespace GestionTareasPendientes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos 
        /// administrados se deben desechar; false en caso contrario.</param>
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
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.txtTareas = new System.Windows.Forms.ListBox();
            this.txtlebel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTarea
            // 
            this.txtTarea.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTarea.Location = new System.Drawing.Point(12, 67);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(143, 20);
            this.txtTarea.TabIndex = 0;
            this.txtTarea.Click += new System.EventHandler(this.button2_Click);
            this.txtTarea.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.BackColor = System.Drawing.Color.Red;
            this.btnEliminarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTarea.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTarea.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnEliminarTarea.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarTarea.Location = new System.Drawing.Point(161, 332);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(145, 45);
            this.btnEliminarTarea.TabIndex = 2;
            this.btnEliminarTarea.Text = "Eliminar tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = false;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAgregarTarea.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarea.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarTarea.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarTarea.Location = new System.Drawing.Point(12, 99);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(143, 43);
            this.btnAgregarTarea.TabIndex = 3;
            this.btnAgregarTarea.Text = "Agregar tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTareas
            // 
            this.txtTareas.BackColor = System.Drawing.SystemColors.Info;
            this.txtTareas.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTareas.FormattingEnabled = true;
            this.txtTareas.ItemHeight = 15;
            this.txtTareas.Location = new System.Drawing.Point(12, 158);
            this.txtTareas.Name = "txtTareas";
            this.txtTareas.Size = new System.Drawing.Size(439, 124);
            this.txtTareas.TabIndex = 5;
            this.txtTareas.Click += new System.EventHandler(this.textBox1_TextChanged);
            this.txtTareas.SelectedIndexChanged += new System.EventHandler(this.lstTareas_SelectedIndexChanged);
            // 
            // txtlebel1
            // 
            this.txtlebel1.AutoSize = true;
            this.txtlebel1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlebel1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtlebel1.Location = new System.Drawing.Point(15, 45);
            this.txtlebel1.Name = "txtlebel1";
            this.txtlebel1.Size = new System.Drawing.Size(97, 13);
            this.txtlebel1.TabIndex = 6;
            this.txtlebel1.Text = "Nueva tarea:";
            this.txtlebel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 415);
            this.Controls.Add(this.txtlebel1);
            this.Controls.Add(this.txtTareas);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.txtTarea);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Form1";
            this.Text = "Gestión de tareas pendientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.ListBox txtTareas;
        private System.Windows.Forms.Label txtlebel1;
    }
}

