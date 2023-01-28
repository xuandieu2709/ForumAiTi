"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("btn-submid-send").disabled = true;

connection.on("ReceiveMessage", function () {
    // var li = document.createElement("li");
    // document.getElementById("messagesList").appendChild(li);
    // // We can assign user-supplied strings to an element's textContent because it
    // // is not interpreted as markup. If you're assigning in any other way, you 
    // // should be aware of possible script injection concerns.
    // li.textContent = `${user} says ${message}`;
    $.ajax({
        type: 'POST',
        // processData: false,  // tell jQuery not to process the data
        // contentType: false,
        url: '/sendChat',
        success: function (result) {
            $('#chat').replaceWith(result);
        },
        error: function (result) {
            alert("Thất bại!" + result);
        }
    });
});
connection.start().then(function () {
    document.getElementById("btn-submid-send").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("btn-submid-send").addEventListener("click", function (event) {
    var message = document.getElementById("exampleFormControlInput2").value;
    var userReceive = $('input#user2').val();
    var file = $('input#upfilechat')[0].files[0];
    var idChat = $('input#MaChat').val();
    var timeSend = new Date().toLocaleString();
    // $('input#upfilechat')[0].files[0]
    console.log(message+userReceive+idChat+timeSend);
    console.log(file);
    alert(file.name + '---\n'+file.type+ '---')
    // var formData = new FormData();
    // formData.append('idChat',$('input#MaChat').val())
    // formData.append('message', message); // myFile is the input type="file" control
    // formData.append('userReceive',userReceive);
    // formData.append('file',file);
    // formData.append('timeSend',new Date().toLocaleString())
    // console.log(file);
    setTimeout(function () {
        connection.invoke("SendMessage1", idChat,userReceive,message).catch(function (err) {
            return console.error(err.toString());
        });
 }, 500);
    event.preventDefault();
});