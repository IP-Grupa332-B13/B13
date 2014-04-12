<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="TeamProject_Soft.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.3/css/bootstrap.min.css">

     <!-- Optional theme -->
     <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.0.3/css/bootstrap-theme.min.css">

      <!-- Latest compiled and minified JavaScript -->
      <script src="//netdna.bootstrapcdn.com/bootstrap/3.0.3/js/bootstrap.min.js"></script>
    <link href="../bootstrap.css" rel="stylesheet">
    <style type="text/css">
      /* Override some defaults */
      html, body {
        background-color: #eee;
      }
      body {
        padding-top: 40px; 
      }
      .container {
        width: 300px;
      }

      /* The white background content wrapper */
      .container > .content {
        background-color: #fff;
        padding: 20px;
        margin: 0 -20px; 
        -webkit-border-radius: 10px 10px 10px 10px;
           -moz-border-radius: 10px 10px 10px 10px;
                border-radius: 10px 10px 10px 10px;
        -webkit-box-shadow: 0 1px 2px rgba(0,0,0,.15);
           -moz-box-shadow: 0 1px 2px rgba(0,0,0,.15);
                box-shadow: 0 1px 2px rgba(0,0,0,.15);
      }

	  .login-form {
		margin-left: 65px;
	  }
	
	  legend {
		margin-right: -50px;
		font-weight: bold;
	  	color: #404040;
	  }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="container">
        <div class="content">
          <div class="row">
            <div class="login-form">
              <h2>Login</h2>
                  <fieldset>
                      <div class="">
                          <asp:TextBox ID="TextBox_LoginUsername" runat="server" placeholder="Username" type="text"></asp:TextBox>
                      </div>                    
                      <br />
                      <div class="clearfix">
                          <asp:TextBox ID="TextBox_LoginPass" runat="server" placeholder="Password" type="password"></asp:TextBox>
                      </div>
                      
                      <br />
                      <asp:Button ID="SignIn" CssClass="btn primary" runat="server" Text="Sign In" OnClick="SignIn_Click" />
                      <br />
                      <br />                    
                  </fieldset>
            </div>
      </div>
    </div>
  </div> <!-- /container -->
    </div>
    </form>
</body>
</html>
