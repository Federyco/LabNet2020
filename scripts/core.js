//escondo la alerta de campo correcto
renew();
//funcion de validación al momento de clikear el boton de submit
document.getElementById("newAccount").onclick = function accountCreated() {
    const nombre = document.getElementById("nombre")
    const apellido = document.getElementById("apellido")
    const edad = document.getElementById("edad")
    const form = document.getElementById("form")
    var approbbed = document.getElementById("approbbed");
    var rejected_name = document.getElementById("rejected_name");
    var rejected_lastName = document.getElementById("rejected_lastName");
    var nombre_a_validar = false;
    var apellido_a_validar = false;

    form.addEventListener("submit", (e) => {
        if (nombre.value === '' || nombre.value == null) {
            rejected_name.hidden = false;
            nombre_a_validar = false;
        }
        else {
            nombre_a_validar = true;
        }
        if (apellido.value === '' || apellido.value == null) {
            rejected_lastName.hidden = false;
            apellido_a_validar = false;
        }
        else {
            apellido_a_validar = true;
        }
        if (nombre_a_validar == true && apellido_a_validar == true) {
            approbbed.hidden = false;
            
        }
    })
    renew();
};

document.getElementById("cleanse_button").onclick = function cleanse() {
    form = document.getElementById("form");
    renew();
    form.reset();

};

function renew()
{
    document.getElementById("approbbed").hidden = true;
    document.getElementById("rejected_name").hidden = true;
    document.getElementById("rejected_lastName").hidden = true;
    document.getElementById("checkboxmasc").disabled = false;
    document.getElementById("checkboxfem").disabled = false;
    document.getElementById("checkboxother").disabled = false;
    document.getElementById("checkboxmasc").hidden = false;
    document.getElementById("checkboxfem").hidden = false;
    document.getElementById("checkboxother").hidden = false;
};

document.getElementById("checkboxmasc").onclick = function hideOthers() {
    var uno = document.getElementById("checkboxfem");
    var dos = document.getElementById("checkboxother");

    uno.hidden = true;
    dos.hidden = true;

};
document.getElementById("checkboxmasc").onclick = function hideFemAndOthers() {
    var masc = document.getElementById("checkboxmasc");
    var fem = document.getElementById("checkboxfem");
    var other = document.getElementById("checkboxother");
    if (masc.hidden == false) {
        masc.disabled = true;
        fem.hidden = true;
        other.hidden = true;

    }
}
document.getElementById("checkboxfem").onclick = function hideMascAndOthers() {
    var masc = document.getElementById("checkboxmasc");
    var fem = document.getElementById("checkboxfem");
    var other = document.getElementById("checkboxother");
    if (fem.hidden == false) {
        fem.disabled = true;
        masc.hidden = true;
        other.hidden = true;
    }
}
document.getElementById("checkboxother").onclick = function hideFemAndMasc() {
    var masc = document.getElementById("checkboxmasc");
    var fem = document.getElementById("checkboxfem");
    var other = document.getElementById("checkboxother");
    if (other.hidden == false) {
        other.disabled = true;
        fem.hidden = true;
        masc.hidden = true;
    }
}
