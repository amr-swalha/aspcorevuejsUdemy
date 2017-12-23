export const ChangeMyColor = {
    inserted: function (el) { //when the element inserted at the html parent node
        console.log("directive inserted");
        //el.style.backgroundColor = "red";
    },
    bind(el, binding, vnode) { //called when the directive binded to the element
        console.log("directive bind");
        el.style.backgroundColor = binding.value;
    },
    update: function (el, binding, vnode) {//Called after the contining component has been updated
        console.log("directive update");
        el.style.backgroundColor = binding.value;
    },
    componentUpdated: function () {//Called after the contining component has been updated andd all of it's children
        console.log("directive componentUpdated");
    },
    unbind: function() { //when the directive is unbinded of the element
        console.log("directive unbind");
    }
}
