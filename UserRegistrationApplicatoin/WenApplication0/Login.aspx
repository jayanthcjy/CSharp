<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication0.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f1f1f1;
        }

        #loginContainer {
            width: 400px;
            margin: 100px auto;
            border: 1px solid #ccc;
            background-color: #fff;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h2 {
            text-align: center;
            color: red;
        }

        label {
            display: block;
            margin-bottom: 10px;
        }

        input[type="text"],
        input[type="password"] {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            margin-bottom: 15px;
        }

        input[type="submit"] {
            width: 100%;
            padding: 10px;
            background-color: red;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        input[type="submit"]:hover {
            background-color: #cc0000;
        }

        .form-links {
            text-align: center;
            margin-top: 15px;
        }

        .form-links a {
            color: #007bff;
            text-decoration: none;
            margin: 0 5px;
        }

        .form-links a:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <div id="loginContainer">
        <h2>User Login</h2>
        <form id="form1" runat="server">
            <label for="txtUserId">User ID</label>
            <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>

            <label for="txtPass">Password</label>
            <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>

            <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" />

            <div class="form-links">
                <asp:Button ID="BtnSignUp" runat="server" Text="Sign Up" OnClick="BtnSignUp_Click" /><br />
                <asp:Button ID="BtnForgetPassword" runat="server" Text="Forgot Password" OnClick="BtnForgetPassword_Click" />
            </div>
        </form>
    </div>
</body>
</html>
