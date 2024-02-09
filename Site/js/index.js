document.addEventListener("DOMContentLoaded", function(){
    const doadorList = document.getElementById("Doador-lista");
    function renderTable(date){
        doadorList.innerHTML = "";

        date.forEach(DoadorTabela => {
            const row = document.createElement("tr");

            row.innerHTML = `
                <td>${DoadorTabela.IdDoador}</td>
                <td>${DoadorTabela.NomeDoador}</td>
                <td>${DoadorTabela.CidadeDoador}</td>
                <td>${DoadorTabela.EstadoDoador}</td>
                <td>${DoadorTabela.CEPDoador}</td>
                <td>${DoadorTabela.EmailDoador}</td>
                <td>${DoadorTabela.TelefoneDoador}</td>
                <td>
                    <button>Editar</button>
                    <button>Excluir</button>
                </td>
            `;
            doadorList.appendChild(row);
        })
    }

    function feachDoador(){
        fetch("https://localhost:7094/api/Doador/CadastrarDoador")
        .then(response => response.json())
        .then(data => renderTable(data))
        .catch(error => console.error("Error ao buscar dados da Api"))
    }
    feachDoador();
}) 