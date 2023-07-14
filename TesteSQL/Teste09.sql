SELECT
	[NOME] AS [Nome do Aluno], 
	[NOTA SEMESTRE 1] AS [Nota do Primeiro Semestre], 
	[NOTA SEMESTRE 2] AS [Nota do Segundo Semestre], 
	[MEDIA] AS [Média Anual],
	[ANO] AS [Ano],
	[STATUS] AS [Status]
FROM [ALUNOS] WHERE [MEDIA] > 6;