# ReportArchitecture

Есть класс, делающий какие-то сложные вычисления, результат которых далее нужно репортить различными способами по прихоти заказчика (добавить отправку на почту, в файл, в базу, потом перестать слать отчеты в базу и т.д.)

Помимо стандартненькой реализации (вариант b в Main), побаловался Interceptor'ами:
https://github.com/soleg1990/ReportArchitecture/commit/47c12dfb5f0c092bdd07908982d2fe57e4e389fb
