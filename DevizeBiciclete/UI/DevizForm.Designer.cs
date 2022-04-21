namespace DevizeBiciclete.UI
{
    partial class DevizForm
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
            DevizeBiciclete.Domain.DevizData.ClientData clientData1 = new DevizeBiciclete.Domain.DevizData.ClientData();
            DevizeBiciclete.Domain.DevizData.BicicletaData bicicletaData1 = new DevizeBiciclete.Domain.DevizData.BicicletaData();
            DevizeBiciclete.Domain.DevizData.ConstatareData constatareData1 = new DevizeBiciclete.Domain.DevizData.ConstatareData();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevizForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownTVA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientControl = new DevizeBiciclete.UI.Controls.ClientControl();
            this.bicicletaControl = new DevizeBiciclete.UI.Controls.BicicletaControl();
            this.constatareControl = new DevizeBiciclete.UI.Controls.ConstatareControl();
            this.piesaListControl = new DevizeBiciclete.UI.Controls.PiesaListControl();
            this.manoperaListControl = new DevizeBiciclete.UI.Controls.ManoperaListControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTVA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.clientControl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bicicletaControl, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.constatareControl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.piesaListControl, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.manoperaListControl, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 469F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 343F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 1790);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(435, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "Deviz";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownTVA, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownNumar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 80);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(991, 50);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // numericUpDownTVA
            // 
            this.numericUpDownTVA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownTVA.AutoSize = true;
            this.numericUpDownTVA.DecimalPlaces = 2;
            this.numericUpDownTVA.Location = new System.Drawing.Point(772, 6);
            this.numericUpDownTVA.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownTVA.Name = "numericUpDownTVA";
            this.numericUpDownTVA.Size = new System.Drawing.Size(99, 38);
            this.numericUpDownTVA.TabIndex = 17;
            this.numericUpDownTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownNumar
            // 
            this.numericUpDownNumar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownNumar.AutoSize = true;
            this.numericUpDownNumar.Location = new System.Drawing.Point(241, 6);
            this.numericUpDownNumar.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownNumar.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDownNumar.Name = "numericUpDownNumar";
            this.numericUpDownNumar.Size = new System.Drawing.Size(178, 38);
            this.numericUpDownNumar.TabIndex = 16;
            this.numericUpDownNumar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numar: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "TVA: ";
            // 
            // clientControl
            // 
            clientData1.Adresa = "";
            clientData1.Denumire = "";
            clientData1.Nume = "";
            clientData1.PersoanaFizica = true;
            clientData1.PersoanaJuridica = false;
            clientData1.Registru = "";
            clientData1.RO = "";
            clientData1.Telefon = "";
            clientData1.TelefonFrima = "";
            this.clientControl.Data = clientData1;
            this.clientControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientControl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientControl.Location = new System.Drawing.Point(5, 158);
            this.clientControl.Margin = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.clientControl.Name = "clientControl";
            this.clientControl.Size = new System.Drawing.Size(987, 439);
            this.clientControl.TabIndex = 8;
            // 
            // bicicletaControl
            // 
            bicicletaData1.Culoare = "";
            bicicletaData1.Marca = "";
            bicicletaData1.Model = "";
            bicicletaData1.Serie = "";
            this.bicicletaControl.Bicicleta = bicicletaData1;
            this.bicicletaControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bicicletaControl.Location = new System.Drawing.Point(5, 607);
            this.bicicletaControl.Margin = new System.Windows.Forms.Padding(5);
            this.bicicletaControl.Name = "bicicletaControl";
            this.bicicletaControl.Size = new System.Drawing.Size(987, 249);
            this.bicicletaControl.TabIndex = 9;
            // 
            // constatareControl
            // 
            constatareData1.DataIn = new System.DateTime(2022, 4, 21, 8, 40, 9, 539);
            constatareData1.DataOut = new System.DateTime(2022, 4, 21, 8, 40, 9, 541);
            constatareData1.Motiv = "";
            this.constatareControl.Constatare = constatareData1;
            this.constatareControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constatareControl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.constatareControl.Location = new System.Drawing.Point(5, 866);
            this.constatareControl.Margin = new System.Windows.Forms.Padding(5);
            this.constatareControl.Name = "constatareControl";
            this.constatareControl.Size = new System.Drawing.Size(987, 236);
            this.constatareControl.TabIndex = 10;
            // 
            // piesaListControl
            // 
            this.piesaListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.piesaListControl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.piesaListControl.Location = new System.Drawing.Point(5, 1112);
            this.piesaListControl.Margin = new System.Windows.Forms.Padding(5);
            this.piesaListControl.Name = "piesaListControl";
            this.piesaListControl.Size = new System.Drawing.Size(987, 324);
            this.piesaListControl.TabIndex = 11;
            this.piesaListControl.Resize += new System.EventHandler(this.manoperaListControl_Resize);
            // 
            // manoperaListControl
            // 
            this.manoperaListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manoperaListControl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manoperaListControl.Location = new System.Drawing.Point(5, 1446);
            this.manoperaListControl.Margin = new System.Windows.Forms.Padding(5);
            this.manoperaListControl.Name = "manoperaListControl";
            this.manoperaListControl.Size = new System.Drawing.Size(987, 339);
            this.manoperaListControl.TabIndex = 12;
            this.manoperaListControl.Resize += new System.EventHandler(this.manoperaListControl_Resize);
            // 
            // DevizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1018, 695);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1000000000, 1000000000);
            this.Name = "DevizForm";
            this.Text = "Deviz ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTVA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label1;
        private NumericUpDown numericUpDownTVA;
        private NumericUpDown numericUpDownNumar;
        private Controls.ClientControl clientControl;
        private Controls.BicicletaControl bicicletaControl;
        private Controls.ConstatareControl constatareControl;
        private Controls.PiesaListControl piesaListControl;
        private Controls.ManoperaListControl manoperaListControl;
    }
}