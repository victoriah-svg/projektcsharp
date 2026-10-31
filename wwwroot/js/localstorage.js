//funktion som tar emot key och value för att spara data i localStorage
window.saveData = function (key, value) {
    localStorage.setItem(key, value);
};

//funktion som tar emot key för att hämta data från localStorage
window.getData = function (key) {
    return localStorage.getItem(key);
};