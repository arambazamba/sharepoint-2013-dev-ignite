﻿
var officeDoc;

Office.initialize = function (reason) {

  // Initialize document variable using Office JavaScript API
  officeDoc = Office.context.document;

  // Add html initialization code using jQuery document ready handler
  $(function () {
    // register event handlers
    $("#cmdReadSelection").click(onReadSelection);
    $("#cmdRegisterEventHandler").click(onRegisterEventHandler);
    $("#cmdTranslate").click(onTranslate);
    $("#cmdWriteSelection").click(onWriteSelection);
  });
}


function onReadSelection() {
  officeDoc.getSelectedDataAsync("text", {}, onReadSelectionComplete);
}

function onReadSelectionComplete(asyncResult) {
  var selection = asyncResult.value;
  $("#display").text(selection);
}

function onRegisterEventHandler() {
  officeDoc.addHandlerAsync("documentSelectionChanged", onSelectionChanged);
}

function onSelectionChanged() {
  officeDoc.getSelectedDataAsync("text", {}, onReadSelectionComplete);
}

function onTranslate() {

  // get value of text inside display element
  var sourceText = $("#display").text();

  // create URL to get JSONP script from bing translation service
  var url = "http://api.microsofttranslator.com/V2/ajax.svc/Translate" +
            "?oncomplete=onTranslateComplete" + // add callback method name
            "&appId=5D28780ED5302B3F6F5E85CE7B7872F76735EBAE" +
            "&from=en" +  // from English
            "&to=es" +    // to Spanish
            "&text=" + sourceText;

  // create script link element using jQuery sytax
  var script = $("<script>", { "src": url });

  // add script to end of head which will run script and execute callback
  $("head").append(script);
}

function onTranslateComplete(translatedText) {
  if (translatedText) {
    $("#display").text(translatedText);
  }
}

function onWriteSelection() {
  officeDoc.setSelectedDataAsync($("#display").text() + "\n");
}