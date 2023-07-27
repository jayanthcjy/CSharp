<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebApplication0.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
        }

        #formContainer {
            margin: 50px auto;
            width: 400px;
            border: 1px solid #ccc;
            border-radius: 5px;
            padding: 20px;
            background-color: #f9f9f9;
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

        #orText {
            text-align: center;
            margin-top: 10px;
            margin-bottom: 20px;
        }

        #loginLink {
            text-align: center;
        }
    </style>
</head>
<body>
    <div id="formContainer">
        <h2>User Registration</h2>
        <form id="form1" runat="server">
            <label for="txtFirstName">First Name</label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>

            <label for="txtLastName">Last Name</label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>

            <label for="txtEmailid">Email ID</label>
            <asp:TextBox ID="txtEmailid" runat="server"></asp:TextBox>

            <label for="txtUserId">UserID</label>
            <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>

            <label for="txtPass">Password</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>

            <asp:Button ID="BtnSave" runat="server" Text="Register" OnClick="BtnSave_Click" />

            <div id="orText">Or</div>

            <div id="loginLink">
                <asp:Button ID="Button2" runat="server" Text="Login" OnClick="BtnLogin_Click" />
            </div>
        </form>
    </div>
</body>
</html>
