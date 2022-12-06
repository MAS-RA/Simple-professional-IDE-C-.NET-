namespace SanIDE
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.runTheCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javaScriptJsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lUAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanLibToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanBuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanCoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDESettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.richTextBox1, null);
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.runToolStripMenuItem,
            this.iDESettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.findToolStripMenuItem,
            this.goToolStripMenuItem,
            this.replaceToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Image = global::SanIDE.Properties.Resources.code__1_;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.cutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.copyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.pasteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.findToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.goToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            this.goToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToolStripMenuItem.Text = "Go to";
            this.goToolStripMenuItem.Click += new System.EventHandler(this.goToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.replaceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBrackets = true;
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.autocompleteMenu1.SetAutocompleteMenu(this.fastColoredTextBox1, this.autocompleteMenu1);
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.fastColoredTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fastColoredTextBox1.LeftBracket = '(';
            this.fastColoredTextBox1.LeftBracket2 = '{';
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.LightCyan;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(0, 24);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.RightBracket2 = '}';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.ServiceLinesColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fastColoredTextBox1.ShowCaretWhenInactive = true;
            this.fastColoredTextBox1.ShowFoldingLines = true;
            this.fastColoredTextBox1.Size = new System.Drawing.Size(800, 426);
            this.fastColoredTextBox1.TabIndex = 2;
            this.fastColoredTextBox1.Text = "// Start Coding :) ";
            this.fastColoredTextBox1.TextAreaBorderColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.WordWrap = true;
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runTheCodeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.selectAllToolStripMenuItem,
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 120);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem1.Text = "Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.cutToolStripMenuItem1_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.AllowsTabKey = true;
            this.autocompleteMenu1.CaptureFocus = true;
            this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
            this.autocompleteMenu1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autocompleteMenu1.ImageList = this.imageList1;
            this.autocompleteMenu1.Items = new string[] {
        "<?php",
        "?>",
        "function() ",
        "fopen();",
        "$String",
        "array(\"\",\"\");",
        "echo \" \";",
        "echo $String;",
        "while(//condition is true) { //Code here }",
        "do {// Code here } while (//condition is true);",
        "foreach (//$array as $value) {//code to be executed;}",
        "for (//init counter; test counter; increment counter) { // code to be executed fo" +
            "r each iteration;}",
        "switch (n) {",
        "  case label1:",
        "    //code to be executed if n=label1;",
        "    break;",
        "  case label2:",
        "    //code to be executed if n=label2;",
        "    break;",
        "  case label3:",
        "    //code to be executed if n=label3;",
        "    break;",
        "    ...",
        "  default:",
        "    //code to be executed if n is different from all labels;",
        "}",
        "if (//condition) {",
        " // code to be executed if condition is true;",
        "}",
        "break;",
        "+",
        "-",
        "*",
        "/",
        "=",
        "==",
        "===",
        "!=",
        "!==",
        "<",
        ">",
        "<=",
        ">=",
        "**",
        "%",
        "define(name, value, case-insensitive);",
        "pi();",
        "max(0, 150, 30, 20, -8, -200);",
        "max(0, 150, 30, 20, -8, -200);",
        "sqrt(64);",
        "round(0.60);",
        "var_dump();",
        "str_word_count();",
        "strrev();",
        "str_replace(\"\",\"\",\"\");",
        "\" \"",
        "\"",
        "\'",
        ".",
        ";",
        ":",
        "->",
        "<-",
        "$this->",
        "$conn",
        "include \' \';",
        "require  \' \':",
        "readfile(\'\');",
        "fread(\'\');",
        "fclose();",
        "fwrite();",
        "basename();",
        "// Allow certain file formats",
        "if($imageFileType != \"jpg\" && $imageFileType != \"png\" && $imageFileType != \"jpeg\"" +
            "",
        "&& $imageFileType != \"gif\" ) {",
        "  echo \"Sorry, only JPG, JPEG, PNG & GIF files are allowed.\";",
        "  $uploadOk = 0;",
        "}",
        "// Check file size",
        "if ($_FILES[\"fileToUpload\"][\"size\"] > 500000) {",
        "  echo \"Sorry, your file is too large.\";",
        "  $uploadOk = 0;",
        "}",
        "if (file_exists($target_file)) {",
        "  echo \"Sorry, file already exists.\";",
        "  $uploadOk = 0;",
        "}",
        "<?php",
        "if(!isset($_COOKIE[$cookie_name])) {",
        "  echo \"Cookie named \'\" . $cookie_name . \"\' is not set!\";",
        "} else {",
        "  echo \"Cookie \'\" . $cookie_name . \"\' is set!<br>\";",
        "  echo \"Value is: \" . $_COOKIE[$cookie_name];",
        "}",
        "?>",
        "$cookie_name = \"user\";",
        "$cookie_value = \"John Doe\";",
        "setcookie($cookie_name, $cookie_value, time() + (86400 * 30), \"/\"); // 86400 = 1 " +
            "day",
        "session_start();",
        "$_SESSION[\"\"];",
        "  foreach (filter_list() as $id =>$filter) {",
        "    echo \'<tr><td>\' . $filter . \'</td><td>\' . filter_id($filter) . \'</td></tr>\';",
        "  }",
        "filter_list();",
        "",
        "if (!filter_var($int, FILTER_VALIDATE_INT) === false) {",
        "  echo(\"Integer is valid\");",
        "} else {",
        "  echo(\"Integer is not valid\");",
        "}",
        "$strings = [\"apple\", \"orange\", \"banana\", \"coconut\"];",
        "$lengths = array_map(\"my_callback\", $strings);",
        "print_r($lengths);",
        "",
        " [\" \", \" \", \" \", \" \"];",
        "json_encode();",
        "json_decode();",
        "",
        "class Fruit {",
        "  // code goes here...",
        "}",
        "class Fruit {",
        "  // Properties",
        "  public $name;",
        "  public $color;",
        "",
        "  // Methods",
        "  function set_name($name) {",
        "    $this->name = $name;",
        "  }",
        "  function get_name() {",
        "    return $this->name;",
        "  }",
        "}",
        "class Fruit {",
        "  public $name;",
        "  public $color;",
        "",
        "  function __construct($name) {",
        "    $this->name = $name;",
        "  }",
        "  function get_name() {",
        "    return $this->name;",
        "  }",
        "}",
        "$servername = \"localhost\";",
        "$username = \"username\";",
        "$password = \"password\";",
        "",
        "// Create connection",
        "$conn = new mysqli($servername, $username, $password);",
        "",
        "// Check connection",
        "if ($conn->connect_error) {",
        "  die(\"Connection failed: \" . $conn->connect_error);",
        "}",
        "echo \"Connected successfully\";",
        "$apple = new Fruit(\"Apple\");",
        "echo $apple->get_name();",
        "class Fruit {// code goes here...}",
        "$servername = \"localhost\";",
        "$username = \"username\";",
        "$password = \"password\";",
        "",
        "// Create connection",
        "$conn = new mysqli($servername, $username, $password);",
        "// Check connection",
        "if ($conn->connect_error) {",
        "  die(\"Connection failed: \" . $conn->connect_error);",
        "}",
        "",
        "// Create database",
        "$sql = \"CREATE DATABASE myDB\";",
        "if ($conn->query($sql) === TRUE) {",
        "  echo \"Database created successfully\";",
        "} else {",
        "  echo \"Error creating database: \" . $conn->error;",
        "}",
        "",
        "$conn->close();",
        "CREATE TABLE MyGuests (",
        "id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,",
        "firstname VARCHAR(30) NOT NULL,",
        "lastname VARCHAR(30) NOT NULL,",
        "email VARCHAR(50),",
        "reg_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP",
        ")",
        "$servername = \"localhost\";",
        "$username = \"username\";",
        "$password = \"password\";",
        "$dbname = \"myDB\";",
        "",
        "// Create connection",
        "$conn = new mysqli($servername, $username, $password, $dbname);",
        "// Check connection",
        "if ($conn->connect_error) {",
        "  die(\"Connection failed: \" . $conn->connect_error);",
        "}",
        "",
        "// sql to create table",
        "$sql = \"CREATE TABLE MyGuests (",
        "id INT(6) UNSIGNED AUTO_INCREMENT PRIMARY KEY,",
        "firstname VARCHAR(30) NOT NULL,",
        "lastname VARCHAR(30) NOT NULL,",
        "email VARCHAR(50),",
        "reg_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP",
        ")\";",
        "",
        "if ($conn->query($sql) === TRUE) {",
        "  echo \"Table MyGuests created successfully\";",
        "} else {",
        "  echo \"Error creating table: \" . $conn->error;",
        "}",
        "",
        "$conn->close();",
        "",
        "$sql = \"INSERT INTO MyGuests (firstname, lastname, email)",
        "VALUES (\'John\', \'Doe\', \'john@example.com\')\";",
        "",
        "if ($conn->query($sql) === TRUE) {",
        "  echo \"New record created successfully\";",
        "} else {",
        "  echo \"Error:",
        ".=",
        "",
        "$servername = \"localhost\";",
        "$username = \"username\";",
        "$password = \"password\";",
        "$dbname = \"myDB\";",
        "",
        "// Create connection",
        "$conn = new mysqli($servername, $username, $password, $dbname);",
        "// Check connection",
        "if ($conn->connect_error) {",
        "  die(\"Connection failed: \" . $conn->connect_error);",
        "}",
        "",
        "$sql = \"SELECT id, firstname, lastname FROM MyGuests WHERE lastname=\'Doe\'\";",
        "$result = $conn->query($sql);",
        "",
        "if ($result->num_rows > 0) {",
        "  // output data of each row",
        "  while($row = $result->fetch_assoc()) {",
        "    echo \"id: \" . $row[\"id\"]. \" - Name: \" . $row[\"firstname\"]. \" \" . $row[\"lastna" +
            "me\"]. \"<br>\";",
        "  }",
        "} else {",
        "  echo \"0 results\";",
        "}",
        "$conn->close();",
        "ORDER BY",
        "$sql = \"DELETE FROM MyGuests WHERE id=3\";",
        "",
        "if ($conn->query($sql) === TRUE) {",
        "  echo \"Record deleted successfully\";",
        "} else {",
        "  echo \"Error deleting record: \" . $conn->error;",
        "}",
        "",
        "$sql = \"UPDATE MyGuests SET lastname=\'Doe\' WHERE id=2\";",
        "",
        "if ($conn->query($sql) === TRUE) {",
        "  echo \"Record updated successfully\";",
        "} else {",
        "  echo \"Error updating record: \" . $conn->error;",
        "}",
        "$sql = \"SELECT * FROM Orders LIMIT 15, 10\";",
        "$sql = \"SELECT * FROM \";",
        "",
        "function showHint(str) {",
        "  if (str.length == 0) {",
        "    document.getElementById(\"txtHint\").innerHTML = \"\";",
        "    return;",
        "  } else {",
        "    var xmlhttp = new XMLHttpRequest();",
        "    xmlhttp.onreadystatechange = function() {",
        "      if (this.readyState == 4 && this.status == 200) {",
        "        document.getElementById(\"txtHint\").innerHTML = this.responseText;",
        "      }",
        "    };",
        "    xmlhttp.open(\"GET\", \"gethint.php?q=\" + str, true);",
        "    xmlhttp.send();",
        "  }",
        "}",
        "<html>",
        "<head>",
        "<script>",
        "function showUser(str) {",
        "  if (str == \"\") {",
        "    document.getElementById(\"txtHint\").innerHTML = \"\";",
        "    return;",
        "  } else {",
        "    var xmlhttp = new XMLHttpRequest();",
        "    xmlhttp.onreadystatechange = function() {",
        "      if (this.readyState == 4 && this.status == 200) {",
        "        document.getElementById(\"txtHint\").innerHTML = this.responseText;",
        "      }",
        "    };",
        "    xmlhttp.open(\"GET\",\"getuser.php?q=\"+str,true);",
        "    xmlhttp.send();",
        "  }",
        "}",
        "</script>",
        "</head>",
        "<body>",
        "",
        "<form>",
        "<select name=\"users\" onchange=\"showUser(this.value)\">",
        "  <option value=\"\">Select a person:</option>",
        "  <option value=\"1\">Peter Griffin</option>",
        "  <option value=\"2\">Lois Griffin</option>",
        "  <option value=\"3\">Joseph Swanson</option>",
        "  <option value=\"4\">Glenn Quagmire</option>",
        "  </select>",
        "</form>",
        "<br>",
        "<div id=\"txtHint\"><b>Person info will be listed here...</b></div>",
        "",
        "</body>",
        "</html>",
        "",
        "function ",
        "",
        "@SAN_BUILD[]"};
            this.autocompleteMenu1.SearchPattern = "[\\w\\.;=!<>]";
            this.autocompleteMenu1.TargetControlWrapper = null;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1200px-Sample_code_icon.svg.png");
            this.imageList1.Images.SetKeyName(1, "93521687Untitled-3-512.png");
            this.imageList1.Images.SetKeyName(2, "YPS__file_document_question_mark_question_sheet_paper_page-512.png");
            this.imageList1.Images.SetKeyName(3, "angle-brackets.png");
            this.imageList1.Images.SetKeyName(4, "code (1).png");
            this.imageList1.Images.SetKeyName(5, "1442581.png");
            this.imageList1.Images.SetKeyName(6, "2721684.png");
            this.imageList1.Images.SetKeyName(7, "0_j8QIJFhW8j91e5Cd.png");
            this.imageList1.Images.SetKeyName(8, "1200px-Sample_code_icon.svg.png");
            // 
            // runTheCodeToolStripMenuItem
            // 
            this.runTheCodeToolStripMenuItem.Image = global::SanIDE.Properties.Resources._1200px_Sample_code_icon_svg;
            this.runTheCodeToolStripMenuItem.Name = "runTheCodeToolStripMenuItem";
            this.runTheCodeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.runTheCodeToolStripMenuItem.Text = "Run the code";
            this.runTheCodeToolStripMenuItem.Click += new System.EventHandler(this.runTheCodeToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Image = global::SanIDE.Properties.Resources.YPS__file_document_question_mark_question_sheet_paper_page_512;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.newToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.pHPToolStripMenuItem,
            this.sQLToolStripMenuItem,
            this.javaScriptJsToolStripMenuItem,
            this.hTMLToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.vBToolStripMenuItem,
            this.lUAToolStripMenuItem,
            this.sanToolStripMenuItem});
            this.languageToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.languageToolStripMenuItem.Image = global::SanIDE.Properties.Resources._1200px_Sample_code_icon_svg;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.cToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.cToolStripMenuItem.Text = "C#";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // pHPToolStripMenuItem
            // 
            this.pHPToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.pHPToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pHPToolStripMenuItem.Name = "pHPToolStripMenuItem";
            this.pHPToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.pHPToolStripMenuItem.Text = "PHP";
            this.pHPToolStripMenuItem.Click += new System.EventHandler(this.pHPToolStripMenuItem_Click);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.sQLToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // javaScriptJsToolStripMenuItem
            // 
            this.javaScriptJsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.javaScriptJsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.javaScriptJsToolStripMenuItem.Name = "javaScriptJsToolStripMenuItem";
            this.javaScriptJsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.javaScriptJsToolStripMenuItem.Text = "JavaScript (Js)";
            this.javaScriptJsToolStripMenuItem.Click += new System.EventHandler(this.javaScriptJsToolStripMenuItem_Click);
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.hTMLToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.hTMLToolStripMenuItem.Text = "HTML";
            this.hTMLToolStripMenuItem.Click += new System.EventHandler(this.hTMLToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.xMLToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // vBToolStripMenuItem
            // 
            this.vBToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.vBToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.vBToolStripMenuItem.Name = "vBToolStripMenuItem";
            this.vBToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.vBToolStripMenuItem.Text = "VB";
            this.vBToolStripMenuItem.Click += new System.EventHandler(this.vBToolStripMenuItem_Click);
            // 
            // lUAToolStripMenuItem
            // 
            this.lUAToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.lUAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lUAToolStripMenuItem.Name = "lUAToolStripMenuItem";
            this.lUAToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.lUAToolStripMenuItem.Text = "LUA";
            this.lUAToolStripMenuItem.Click += new System.EventHandler(this.lUAToolStripMenuItem_Click);
            // 
            // sanToolStripMenuItem
            // 
            this.sanToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.sanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sanLibToolStripMenuItem,
            this.sanBuildToolStripMenuItem,
            this.sanHeaderToolStripMenuItem,
            this.sanCoreToolStripMenuItem,
            this.sanStartToolStripMenuItem});
            this.sanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sanToolStripMenuItem.Name = "sanToolStripMenuItem";
            this.sanToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sanToolStripMenuItem.Text = "San";
            this.sanToolStripMenuItem.Click += new System.EventHandler(this.sanToolStripMenuItem_Click);
            // 
            // sanLibToolStripMenuItem
            // 
            this.sanLibToolStripMenuItem.Name = "sanLibToolStripMenuItem";
            this.sanLibToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sanLibToolStripMenuItem.Text = "San Lib";
            // 
            // sanBuildToolStripMenuItem
            // 
            this.sanBuildToolStripMenuItem.Name = "sanBuildToolStripMenuItem";
            this.sanBuildToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sanBuildToolStripMenuItem.Text = "San Build";
            // 
            // sanHeaderToolStripMenuItem
            // 
            this.sanHeaderToolStripMenuItem.Name = "sanHeaderToolStripMenuItem";
            this.sanHeaderToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sanHeaderToolStripMenuItem.Text = "San Header ";
            // 
            // sanCoreToolStripMenuItem
            // 
            this.sanCoreToolStripMenuItem.Name = "sanCoreToolStripMenuItem";
            this.sanCoreToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sanCoreToolStripMenuItem.Text = "San Core";
            // 
            // sanStartToolStripMenuItem
            // 
            this.sanStartToolStripMenuItem.Name = "sanStartToolStripMenuItem";
            this.sanStartToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sanStartToolStripMenuItem.Text = "San Start";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.runToolStripMenuItem.Image = global::SanIDE.Properties.Resources._1200px_Sample_code_icon_svg;
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // iDESettingsToolStripMenuItem
            // 
            this.iDESettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeColorToolStripMenuItem,
            this.themeTextColorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.iDESettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iDESettingsToolStripMenuItem.Image = global::SanIDE.Properties.Resources._93521687Untitled_3_512;
            this.iDESettingsToolStripMenuItem.Name = "iDESettingsToolStripMenuItem";
            this.iDESettingsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.iDESettingsToolStripMenuItem.Text = "IDE Settings";
            // 
            // themeColorToolStripMenuItem
            // 
            this.themeColorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.themeColorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.themeColorToolStripMenuItem.Name = "themeColorToolStripMenuItem";
            this.themeColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.themeColorToolStripMenuItem.Text = "Background Color";
            this.themeColorToolStripMenuItem.Click += new System.EventHandler(this.themeColorToolStripMenuItem_Click);
            // 
            // themeTextColorToolStripMenuItem
            // 
            this.themeTextColorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.themeTextColorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.themeTextColorToolStripMenuItem.Name = "themeTextColorToolStripMenuItem";
            this.themeTextColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.themeTextColorToolStripMenuItem.Text = "Text Color";
            this.themeTextColorToolStripMenuItem.Click += new System.EventHandler(this.themeTextColorToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.fontToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "San IDE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDESettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeTextColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem javaScriptJsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lUAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanLibToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanBuildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanCoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runTheCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

