//Problem 1
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
};

let sum = 0;

for (person in salaries) {
    sum += salaries[person];
}

console.log(sum);

//Problem 2
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};

function multiplyNumeric(menu) {
    for (var prop in menu) {
        if (typeof menu[prop] === 'number') {
            menu[prop] *= 2;
        }
    }
}

multiplyNumeric(menu);
console.log(menu);

//Problem 3
function checkEmailId(str) {
    var mailFormat = /^[\w-.]+@([\w-]+\.)+[\w-]{2,}$/i;
    return mailFormat.test(str)
}

console.log(checkEmailId("good@gmail.com"));

//Problem 4
function truncate(str, maxlength) {
    if (str.length < maxlength) {
        return str
    }

    let substring = str.slice(0, maxlength - 1);
    let ellipsis = "...";
    //console.log(substring);
    return substring + ellipsis;
}

let test = truncate("What I'd like to tell on this topic is:", 20);
console.log(test);
test = truncate("Hi everyone!", 20);
console.log(test);

//Problem 5
let arr = ["James", "Brennie"];
console.log(arr);
arr.push("Robert");
console.log(arr);
arr[Math.floor(arr.length / 2)] = "Calvin";
console.log(arr);
arr.shift();
console.log(arr);
arr.unshift("Rose", "Regal");
console.log(arr);