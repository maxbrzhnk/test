$(document).ready(function () {

    GetAllArticles();

    $("#editArticle").click(function (event) {
        event.preventDefault();
        EditArticle();
    });

    $("#addArticle").click(function (event) {
        event.preventDefault();
        AddArticle();
    });

});
function GetAllArticles() {

    $("#createBlock").css('display', 'block');
    $("#editBlock").css('display', 'none');
    $.ajax({
        url: '/api/values',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            WriteResponse(data);
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}
function AddArticle() {
    var article = {
        Language: $('#addLanguage').val(),
        Header: $('#addHeader').val(),
        TextTeaser: $('#addTextTeaser').val(),
        HtmlContent: $('#addHtmlContent').val(),
        ImageUrlTeaser: $('#addImageUrlTeaser').val(),
        ImageUrl: $('#addImageUrl').val()
    };

    $.ajax({
        url: '/api/values/',
        type: 'POST',
        data: JSON.stringify(article),
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            GetAllArticles();
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function DeleteArticle(id) {

    $.ajax({
        url: '/api/values/' + id,
        type: 'DELETE',
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            GetAllArticles();
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function EditArticle() {
    var id = $('#editId').val()
    var article = {
        Id: $('#editId').val(),
        Language: $('#editLanguage').val(),
        Header: $('#editHeader').val(),
        TextTeaser: $('#editTextTeaser').val(),
        HtmlContent: $('#editHtmlContent').val(),
        ImageUrlTeaser: $('#editImageUrlTeaser').val(),
        ImageUrl: $('#editImageUrl').val()
    };
    $.ajax({
        url: '/api/values/' + id,
        type: 'PUT',
        data: JSON.stringify(article),
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            GetAllArticles();
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function WriteResponse(books) {
    var strResult = "<table><th>ID</th><th>Language</th><th>Header</th><th>TextTeaser</th><th>HtmlContent</th><th>ImageUrlTeaser</th><th>ImageUrl</th>";
    $.each(books, function (index, book) {
        strResult += "<tr><td>" + book.Id + "</td><td> " + book.Language + "</td><td>" +
            book.Header + "</td><td>" + book.TextTeaser + "</td><td> " +
            book.HtmlContent + "</td><td> " + book.ImageUrlTeaser + "</td><td>" +
            book.ImageUrl +
            "</td><td><a id='editItem' data-item='" + book.Id + "' onclick='EditItem(this);' >Edit</a></td>" +
            "<td><a id='delItem' data-item='" + book.Id + "' onclick='DeleteItem(this);' >Delete</a></td></tr>";
    });
    strResult += "</table>";
    $("#tableBlock").html(strResult);

}
function DeleteItem(el) {
    var id = $(el).attr('data-item');
    DeleteArticle(id);
}
function EditItem(el) {
    var id = $(el).attr('data-item');
    GetArticle(id);
}
function ShowBook(article) {
    if (article != null) {
        $("#createBlock").css('display', 'none');
        $("#editBlock").css('display', 'block');
        $("#editId").val(article.Id);
        $("#editLanguage").val(article.Language);
        $("#editHeader").val(article.Header);
        $("#editTextTeaser").val(article.TextTeaser);
        $("#editHtmlContent").val(article.HtmlContent);
        $("#editImageUrlTeaser").val(article.ImageUrlTeaser);
        $("#editImageUrl").val(article.ImageUrl);
    }
    else {
        alert("Такая книга не существует");
    }
}
function GetArticle(id) {
    $.ajax({
        url: '/api/values/' + id,
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            ShowBook(data);
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}