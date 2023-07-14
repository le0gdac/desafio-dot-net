ALTER TABLE [ALUNOS]
ADD [MEDIA] DECIMAL (4,2),
	[STATUS] [CHAR] (10);

UPDATE [ALUNOS]
SET [MEDIA] = ([NOTA SEMESTRE 1] + [NOTA SEMESTRE 2]) / 2;
UPDATE [ALUNOS]
SET [STATUS] = 'Aprovado' WHERE [MEDIA] >= 6.5;
UPDATE [ALUNOS]
SET [STATUS] = 'Reprovado' WHERE [MEDIA] < 6.5;

SELECT
	[NOME] AS [Nome do Aluno], 
	[NOTA SEMESTRE 1] AS [Nota do Primeiro Semestre], 
	[NOTA SEMESTRE 2] AS [Nota do Segundo Semestre], 
	[MEDIA] AS [Média Anual],
	[ANO] AS [Ano],
	[STATUS] AS [Status]
FROM [ALUNOS];