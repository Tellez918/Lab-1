<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Create</title>
</head>
<body>
    <form action="/Videos/Create" method="post">
    <fieldset>
        <legend>Datos contacto</legend>
        <label for = "idVideo">idVideo</label>
        <input type = "text" name = "idVideo" />

        <label for = "titulo">titulo</label>
        <input type = "text" name = "titulo" />

        <label for = "numReprod">numReprod</label>
        <input type = "text" name = "numReprod" />

        <label for = "urlVideo">urlVideo</label>
        <input type = "text" name = "urlVideo" />

        <input type ="submit" value = "Registrar Video" />

    </fieldset>
    </form>
</body>
</html>
