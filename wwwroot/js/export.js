function exportToExcel(data, fileName) {
    let csvContent = "data:text/csv;charset=utf-8,\uFEFF";

    if (Array.isArray(data[0])) {
        csvContent += data[0].map(item => `"${item}"`).join(",") + "\n";
    } else {
        console.log("Data is invalid");
        return;
    }
    data.slice(1).forEach(function (rowArray) {
        let row = rowArray.map(item => `"${item.replace(/"/g, '""')}"`).join(",");
        csvContent += row + "\n";
    });

    let encodedUri = encodeURI(csvContent);
    let link = document.createElement("a");
    link.setAttribute("href", encodedUri);
    link.setAttribute("download", fileName);
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}
