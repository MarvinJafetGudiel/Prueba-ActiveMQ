# Prueba de concepto con ActiveMQ usando C#

# Link a la presentacion de canva

https://www.canva.com/design/DAHDy0wdJm0/cxf8tP-NuenSILIrzlH1Yw/view?utm_content=DAHDy0wdJm0&utm_campaign=designshare&utm_medium=link2&utm_source=uniquelinks&utlId=h285f263ddc

# Descripción

En este proyecto realizamos una pequeña prueba de concepto utilizando C# y Apache ActiveMQ para entender cómo funciona la comunicación mediante colas de mensajes.

La idea principal fue crear dos aplicaciones de consola:

Un Producer que envía mensajes.

Un Consumer que recibe esos mensajes.

De esta forma se puede ver cómo dos programas pueden comunicarse entre sí usando un intermediario que gestiona los mensajes.

# Cómo funciona

Se ejecuta ActiveMQ, que actúa como servidor de mensajería.

El programa Producer se conecta al servidor y envía un mensaje a una cola.

El programa Consumer se conecta a esa misma cola y espera recibir mensajes.

Cuando el Producer envía el mensaje, el Consumer lo recibe y lo muestra en pantalla.

Esto demuestra cómo funciona la comunicación mediante colas usando ActiveMQ.

Tecnologías utilizadas

Para esta práctica utilizamos las siguientes herramientas:

C#

.NET

Apache ActiveMQ

Librería Apache.NMS.ActiveMQ

Visual Studio
