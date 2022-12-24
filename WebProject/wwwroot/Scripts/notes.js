
    function boldText() {
        document.getElementById("textarea1").style.fontWeight = "bold";
}

    function italicText() {
        document.getElementById("textarea1").style.fontStyle = "italic";
}
    function download() {
        var text = document.getElementById("textarea1").value;
        text = text.replace(/\n/g, "\r\n");
        var blob = new Blob([text], { type: "text/plain" });
        var anchor = document.createElement("a");
        anchor.download = document.getElementById("notesfilename").value + ".txt";
        anchor.href = window.URL.createObjectURL(blob);
        anchor.target = "_blank";
        anchor.style.display = "none";
        document.body.appendChild(anchor);
        anchor.click();
        document.body.removeChild(anchor);
}