using System;
using System.Windows.Forms;

namespace WinForms_Examples
{
    public partial class frmMain : Form
    {

        Zoople.HTMLEditControl oEdit;

        public frmMain()
        {

            InitializeComponent();

            oEdit = new Zoople.HTMLEditControl
            {
                Dock = DockStyle.Fill,
                DocumentHTML = "<h2>The simplest and most extensible Winforms HTML Editor.</h2><img align='right' src='https://zoople.tech/img/logo.png?1' /><p>Caters for all levels of end-user, from the most basic to people with advanced HTML knowledge.</p><p>Complete HTML DOM manipulation is achievable, simply and without the need for COM references</p>",
                ShowPropertyGrid = true,
                CSSText = "img {border: none;-ms-interpolation-mode: bicubic;/*max-width: 100%;*/		max-width: 580px;		}body {background-color: #f6f6f6;font-family: sans-serif;-webkit-font-smoothing: antialiased;font-size: 14px;line-height: 1.4;margin: 0;padding: 0;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%; }table {border-collapse: separate;mso-table-lspace: 0pt;mso-table-rspace: 0pt;width: 100%; }table td {  font-family: sans-serif;  font-size: 14px;  vertical-align: top; }/* -------------------------------------  BODY & CONTAINER------------------------------------- */.body {background-color: #f6f6f6;width: 100%; }/* Set a max-width, and make it display as block so it will automatically stretch to that width, but will also shrink down on a phone or something */.container {display: block;Margin: 0 auto !important;/* makes it centered */max-width: 580px;padding: 10px;width: 580px; }/* This should also be a block element, so that it will fill 100% of the .container */.content {box-sizing: border-box;display: block;Margin: 0 auto;max-width: 580px;padding: 10px; }/* -------------------------------------  HEADER, FOOTER, MAIN------------------------------------- */.main {background: #ffffff;border-radius: 3px;width: 100%; }.wrapper {box-sizing: border-box;padding: 20px; }.content-block {padding-bottom: 10px;padding-top: 10px;}.footer {clear: both;Margin-top: 10px;text-align: center;width: 100%; }.footer td,.footer p,.footer span,.footer a {  color: #999999;  font-size: 12px;  text-align: center; }/* -------------------------------------  TYPOGRAPHY------------------------------------- */h1,h2,h3,h4 {color: #000000;font-family: sans-serif;font-weight: 400;line-height: 1.4;margin: 0;Margin-bottom: 30px; }h1 {font-size: 35px;font-weight: 300;text-align: center;text-transform: capitalize; }p,ul,ol {font-family: sans-serif;font-size: 14px;font-weight: normal;margin: 0;Margin-bottom: 15px; }p li,ul li,ol li {  list-style-position: inside;  margin-left: 5px; }a {color: #3498db;text-decoration: underline; }/* -------------------------------------  BUTTONS------------------------------------- */.btn {box-sizing: border-box;width: 100%; }.btn > tbody > tr > td {  padding-bottom: 15px; }.btn table {  width: auto; }.btn table td {  background-color: #ffffff;  border-radius: 5px;  text-align: center; }.btn a {  background-color: #ffffff;  border: solid 1px #3498db;  border-radius: 5px;  box-sizing: border-box;  color: #3498db;  cursor: pointer;  display: inline-block;  font-size: 14px;  font-weight: bold;  margin: 0;  padding: 12px 25px;  text-decoration: none;  text-transform: capitalize; }.btn-primary table td {background-color: #3498db; }.btn-primary a {background-color: #3498db;border-color: #3498db;color: #ffffff; }",
                LicenceKey = "YourLicenseKey",
                LicenceKeyInlineSpelling = "InlineSpellingLicenseKey",
                EnableInlineSpelling = false,
                CleanMSWordHTMLOnPaste = true,
                FontSizesList = "8pt;10pt;12pt;16pt;22pt;",
                HideDOMToolbar = false
            };

            Controls.Add(oEdit);

        }
    }
}
