<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FlyweightPattern.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body{
            background-color:gainsboro;
        }

        .primary {
            width: 60%;
            margin: 20px auto;
            display: flex;
            align-content: space-between;
            justify-content: space-between;
        }

        .primary > input {
            width: 150px;
            height: 150px;
            border: 1px solid white;
            border-radius: 50%;
            cursor:pointer;
        }

        .secondary {
            width: 60%;
            margin: 20px auto;
            display: flex;
            align-content:center;
            justify-content: center;
        }

        .secondary > input {
            width: 100px;            
            border: 1px solid white;
            cursor:pointer;
        }


    </style>
</head>

<body>
    <form runat="server">
     <div class="primary">
         <asp:Button runat="server" ID="btn1"     Text="Player 1"     OnClick="btn_Click" />
         <asp:Button runat="server" ID="btn2"     Text="Player 2"     OnClick="btn_Click" />         
     </div>
        <div class="secondary">
         <asp:Button runat="server" ID="btnReset"     Text="Reset"     OnClick="start" />
     </div>
    </form>

</body>
</html>
