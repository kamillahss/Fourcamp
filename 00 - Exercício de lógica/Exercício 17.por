programa
{
	
	funcao inicio()
	{
		//Solicite o nome, e-mail, rg e cpf da pessoa. Faça uma validação simples para verificar se todos os campos foram preenchidos.
		cadeia nome, email, rg, cpf

		escreva("Insira seu nome: ")
		leia(nome)
		escreva("Insira seu e-mail: ")
		leia(email)
		escreva("Insira seu RG: ")
		leia(rg)
		escreva("Insira seu CPF: ")
		leia(cpf)

		se(nome == "")
		{
			escreva("Preencher campo nome!")
		}
		se(email == "")
		{
			escreva("Preencher campo e-mail!")
		}
		se(rg == "")
		{
			escreva("Preencher campo RG!")
		}
		se(cpf == "")
		{
			escreva("Preencher campo CPF!")
		}senao 
		{
			escreva("Cadastro realizado com sucesso!")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 666; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */