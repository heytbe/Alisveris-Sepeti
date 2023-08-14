let productdetail = document.querySelector(".productdetail"),
imgboxheight;
let cartbutton = document.querySelector(".icon i");
let modalcart = document.querySelector(".modalcard");

if (productdetail != null) {
    imgboxheight = productdetail.children[0].clientHeight;
    productdetail.children[1].style.height = imgboxheight + "px";


var tiklama = 0;
cartbutton.addEventListener("click",function(){
    if(tiklama === 0){
        modalcart.style.display = "block";
        tiklama++;
    }else{
        modalcart.style.display = "none";
        tiklama = 0;
    }
});

let modalcard = document.querySelector(".modalcard");
let iconsize = document.querySelector(".icon p");
productdetail.children[1].children[1].children[1].addEventListener("click",function(){
    let html = `<div class="modalproduct">
                <div class="imgbox">
                    <img src="${this.parentElement.parentElement.previousElementSibling.children[0].getAttribute("src")}" alt="">
                </div>
                <div class="textbox">
                ${this.parentElement.previousElementSibling.innerText}
                ${this.previousElementSibling.value}
                </div>
                </div>`;
    modalcard.insertAdjacentHTML("afterbegin",html);
    iconsize.innerText = modalcard.children.length;
});
}
////////////////////////////////////////////////////////////////

let tablebutton = document.querySelectorAll(".tablebutton"),
childtable = document.querySelectorAll(".childtable");
if(tablebutton != null){
    
   for(let i = 0; i < tablebutton.length;i++){
    let tik = 0;
     tablebutton[i].addEventListener("click",function(){
        if(tik === 0){
            this.children[0].classList.remove("fa-square-caret-down");
            this.children[0].classList.add("fa-square-caret-up");
            childtable[i].classList.remove("none");
            tik++;
        }else{
            this.children[0].classList.remove("fa-square-caret-up");
            this.children[0].classList.add("fa-square-caret-down");
            childtable[i].classList.add("none");
            tik = 0;
        }
     });
   }
}