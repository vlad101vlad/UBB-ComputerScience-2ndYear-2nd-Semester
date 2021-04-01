function compareValuesAscending(a, b){
    return (a<b) ? -1 : (a>b) ? 1 : 0;
}

function compareValuesDescending(a, b){
    return (a>b) ? -1 : (a<b) ? 1 : 0;
}


let table = document.getElementById("f1-table");

let currentSort = 0;

function sortTable(column){
    let rows =  Array.from(table.rows);
    console.log(column);
    //We eliminate the row with the header
    rows = rows.slice(1);

    let querySelector = 'td:nth-child(' + column + ")";


    rows.sort(
        (row1, row2) => {
            let t1 = row1.querySelector(querySelector);
            let t2 = row2.querySelector(querySelector);

            if(currentSort >= 0){
                return compareValuesAscending(t1.textContent, t2.textContent);
            }
            return compareValuesDescending(t1.textContent, t2.textContent);
        }
    )

    if(currentSort === 0){
        currentSort++;
    }

    rows.forEach(row => table.appendChild(row));
    currentSort *= -1;
}