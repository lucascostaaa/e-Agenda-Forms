SELECT * FROM TBCONTATO
SELECT 
                CP.[ID],
                CP.[DATA],
                CP.[ASSUNTO],
                CP.[LOCAL],
                CP.[HORAINICIO],
                CP.[HORATERMINO],
                CP.[ID_CONTATO],
                CP.[LINK],
                CT.[NOME],
                CT.[EMAIL],
                CT.[TELEFONE],
                CT.[CARGO], 
                CT.[EMPRESA] 
            FROM
                [TBCOMPROMISSO] AS CP LEFT JOIN 
                [TBCONTATO] AS CT
            ON
                CT.ID = CP.ID_CONTATO
            WHERE 
                CP.[ID] = 7