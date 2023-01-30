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

$(document).on("click","button#btn-submid-send", function (event) {
    var message = document.getElementById("exampleFormControlInput2").value;
    var userReceive = $('input#user2').val();
    var file = $('input#upfilechat')[0].files[0];
    var idChat = $('input#MaChat').val();
    var images,namefile,typefile;
    if(file > 0)
    {
    namefile = file.name;
    typefile = file.type;
    }else{
    namefile = null;
    typefile = null;
    }
    // var imageData;
    // var reader;
    // if (file) {
    //             reader = new FileReader();
    //             reader.onload = function (e) {
    //                 imageData =  e.target.result;
    //             }
    //             reader.readAsDataURL(file);
    //         }
    //         $('textarea#exampleFormControlInput2').text(imageData);
    // alert(imageData)
    // // $('input#upfilechat')[0].files[0]
    // console.log(imageData);
    var formData = new FormData();
    formData.append('idChat',$('input#MaChat').val())
    formData.append('message', message); // myFile is the input type="file" control
    formData.append('userReceive',userReceive);
    formData.append('file',file);
    formData.append('timeSend',new Date().toLocaleString())
    //
    
    console.log(file);
    if(message === null || message === '')
    {
    }else{
        setTimeout(function () {
            if(file > 0)
            {
                // connection.invoke("SendMessage1", idChat,userReceive,message,namefile,typefile).catch(function (err) {
                //     return console.error(err.toString());
                // });
            }
            else{
                connection.invoke("SendMessage1", idChat,userReceive,message).catch(function (err) {
                    return console.error(err.toString());
                });
            }
     }, 50);
    }
    event.preventDefault();
});

//
// function fileToByteArray(file) {
//     var reader = new FileReader();
//   reader.onload = function() {

//     var arrayBuffer = this.result,
//       array = new Uint8Array(arrayBuffer),
//       binaryString = String.fromCharCode.apply(null, array);
//       return binaryString;
//   }

//     // return new Promise((resolve, reject) => {
//     //     try {
//     //         let reader = new FileReader();
//     //         let fileByteArray = [];
//     //         reader.readAsArrayBuffer(file);
//     //         reader.onloadend = (evt) => {
//     //             if (evt.target.readyState == FileReader.DONE) {
//     //                 let arrayBuffer = evt.target.result,
//     //                     array = new Uint8Array(arrayBuffer);
//     //                 for (byte of array) {
//     //                     fileByteArray.push(byte);
//     //                 }
//     //             }
//     //             resolve(fileByteArray);
//     //         }
//     //     }
//     //     catch (e) {
//     //         reject(e);
//     //     } 
//     // })
// }

$('#details-chat').scrollTop($('#details-chat')[0].scrollHeight);

//