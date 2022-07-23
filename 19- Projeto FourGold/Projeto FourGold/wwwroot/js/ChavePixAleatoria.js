$(document).ready(function () {
    const tipoChave = document.getElementById("tipoChave");
    const divCampo = document.getElementById("campoChave");
    const $inputChave = $("#inputCadastrarChave");

    tipoChave.addEventListener("change", () => {
        if (tipoChave.options[tipoChave.selectedIndex].value == 3)
            divCampo.style.display = "none";
        else {
            divCampo.style.display = "block";
            if (tipoChave.options[tipoChave.selectedIndex].value == 0) {
                $inputChave.mask('000.000.000-00', { reverse: true });
            }
            else if (tipoChave.options[tipoChave.selectedIndex].value == 1) {
                $inputChave.mask("A", {
                    translation: {
                        "A": { pattern: /[\w@\-.+]/, recursive: true }
                    }
                });
            }
            else if (tipoChave.options[tipoChave.selectedIndex].value == 2) {
                $inputChave.mask('(00) 00000-0000', { reverse: false });
            }
        }
    })
});

