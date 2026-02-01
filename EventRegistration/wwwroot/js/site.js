// CSV Download Function for Event Payments Export
window.downloadFile = function (filename, base64Data) {
    const link = document.createElement('a');
    link.href = 'data:text/csv;base64,' + base64Data;
    link.download = filename;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
};