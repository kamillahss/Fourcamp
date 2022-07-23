$(document).ready(function () {
    const select = document.getElementById("selectTipo");
    const $campoPix = $("#inputChave");
    select.addEventListener("change", () => {
        if (select.options[select.selectedIndex].value == 0)
            $campoPix.mask('000.000.000-00', { reverse: true });
        else if (select.options[select.selectedIndex].value == 1) {
            $campoPix.mask("A", {
                translation: {
                    "A": { pattern: /[\w@\-.+]/, recursive: true }
                }
            });
        }
        else if (select.options[select.selectedIndex].value == 2)
            $campoPix.mask('(00) 00000-0000', { reverse: false });
        else
            $campoPix.unmask();
    })
});