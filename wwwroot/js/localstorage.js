window.saveData = function (key, value) {
    localStorage.setItem(key, value);
};

window.getData = function (key) {
    return localStorage.getItem(key);
};