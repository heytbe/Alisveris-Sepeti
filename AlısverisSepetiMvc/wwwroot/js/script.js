let deneme = document.querySelectorAll(".submenuli");
let menubtn = document.querySelector(".menuopenclosebtn");
let menuarea = document.querySelector(".menu");
let container = document.querySelector(".container");
for (let i = 0; i < deneme.length; i++) {
    let clickCount = 0;
    deneme[i].addEventListener("click", () => {
        if (clickCount === 0) {
            clickCount = 1;
            deneme[i].style.height = "auto";
            deneme[i].classList.add("menuactive");
            deneme[i].children[1].style.display = "block";
            deneme[i].children[0].children[1].classList.remove("fa-caret-down");
            deneme[i].children[0].children[1].classList.add("fa-caret-up");
        } else {
            clickCount = 0;
            deneme[i].style.height = "35px";
            deneme[i].classList.remove("menuactive");
            deneme[i].children[1].style.display = "none";
            deneme[i].children[0].children[1].classList.remove("fa-caret-up");
            deneme[i].children[0].children[1].classList.add("fa-caret-down");
        }
    });
}

/*let subcategoryformbtn = document.querySelector("body .subcategoryformbtn"),
subcategoryform = document.querySelector("body .subcategoryform");
subcategoryformbtn.addEventListener("click",()=>{
    subcategoryform.style.display = "block";
});*/

let menubtnclickcount = 0;
menubtn.addEventListener("click", () => {
    if (menubtnclickcount === 0) {
        menuarea.style.width = "80px";
        menuarea.classList.add("shrink");
        container.style.width = "calc(100% - 80px)";
        menubtn.classList.remove("fa-arrow-left-long");
        menubtn.classList.add("fa-arrow-right-long");
        menubtnclickcount = 1;
    } else {
        menuarea.style.width = "250px";
        menuarea.classList.remove("shrink");
        container.style.width = "calc(100% - 250px)";
        menubtn.classList.remove("fa-arrow-right-long");
        menubtn.classList.add("fa-arrow-left-long");
        menubtnclickcount = 0;
    }
});


let imagepreviewlabel = document.querySelectorAll(".imagepreview label"),
imagepreview = document.querySelectorAll(".imagepreview");
for(let i =0; i < imagepreview.length;i++){
    imagepreview[i].children[1].addEventListener("click",()=>{
       imagepreview[i].children[0].addEventListener("change",()=>{
        console.log(imagepreview[i].children[0]);
        imagepreview[i].children[1].classList.add("none");
        imagepreview[i].children[2].classList.remove("none");
        console.log(imagepreview[i].children[0].files[0]);
        let reader = new FileReader(imagepreview[i].children[0].files[0]);
        reader.onload = () =>{
            reader.name = imagepreview[i].children[0].files[0].name;
            imagepreview[i].children[2].setAttribute("src",reader.result);
        };
        reader.readAsDataURL(imagepreview[i].children[0].files[0]);
       });
    });

    /*imagepreviewinput[i].addEventListener("change", () => {
    imagepreviewlabel[i].classList.add("none");
        imagepreviewimg[i].classList.remove("none");
        let reader = new FileReader(imagepreviewinput[i].files[0]);
        reader.onload = () => {
            reader.name = imagepreviewinput[i].files[0].name;
            imagepreviewimg[i].setAttribute("src", reader.result);
        };

        reader.readAsDataURL(imagepreviewinput[i].files[0]);
    });*/
}

let topictitle = document.querySelectorAll(".topictitle");

for (let i = 0; i < topictitle.length; i++) {
    if (topictitle[i].innerText != "0") {
        topictitle[i].addEventListener("click",()=>{
            topictitle[i].parentElement.nextElementSibling.classList.remove("none");
        });
    }
}

var ckeditor = document.querySelectorAll(".questiontext");
for (let i = 0; i < ckeditor.length; i++) {
    CKEDITOR.replace(ckeditor[i]);
}

let tablebutton = document.querySelectorAll(".tablebutton"),
    childtable = document.querySelectorAll(".childtable");
if (tablebutton != null) {

    for (let i = 0; i < tablebutton.length; i++) {
        let tik = 0;
        tablebutton[i].addEventListener("click", function () {
            if (tik === 0) {
                this.children[0].classList.remove("fa-square-caret-down");
                this.children[0].classList.add("fa-square-caret-up");
                childtable[i].classList.remove("none");
                tik++;
            } else {
                this.children[0].classList.remove("fa-square-caret-up");
                this.children[0].classList.add("fa-square-caret-down");
                childtable[i].classList.add("none");
                tik = 0;
            }
        });
    }
}

