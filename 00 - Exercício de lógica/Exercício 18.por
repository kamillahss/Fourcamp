programa
{
	
	funcao inicio()
	{
		//Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
  		//● para homens: (72.7 * h) – 58; ● para mulheres: (62.1 * h) – 44.7.
		real altura, pesoH, pesoM
		cadeia sexo 
		
		escreva("Qual sua altura?")
		leia(altura)
		escreva("Qual o seu sexo?(M para masculino ou F para feminino)")
		leia(sexo)

		se(sexo == "f")
		{
			pesoM = (62.1 * altura) - 44.7
			escreva("Seu peso ideal é: ", pesoM)
		}
		se(sexo == "m")
		{
			pesoH = (72.7 * altura) - 58
			escreva("Seu peso ideal é: ", pesoH)
		}
  
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 431; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */