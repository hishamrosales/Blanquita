Sistema de Gestión de Equipos y Torneos Deportivos
Descripción
Sistema desarrollado en C# para la gestión integral de equipos, jugadores y torneos tanto de deportes tradicionales como de eSports. Permite administrar jugadores, equipos, organizar torneos, calcular estadísticas y simular partidos.

Características Principales
Gestión de Jugadores
Crear jugadores de deportes y eSports

Asignar características especiales (posición, rol)

Sistema de niveles y estrellas (1-5 estrellas)

Estadísticas individuales detalladas

Gestión de Equipos
Crear equipos de deportes y eSports

Añadir/remover jugadores de equipos

Cálculo de promedio de nivel por equipo

Visualización de plantillas completas

Sistema de Torneos
Organización de torneos de 4 u 8 equipos

Generación automática de brackets

Sistema de puntuación y ranking

Historial completo de torneos

Estadísticas y Análisis
Ranking general de jugadores

Comparación entre jugadores y equipos

Estadísticas individuales y por equipos

Logros y MVP automáticos

Tecnologías Utilizadas
Lenguaje: C#

Plataforma: .NET Framework

Estructuras de Datos: Listas, Diccionarios, Colas (Queue), Pilas (Stack), Genéricos

Instalación y Ejecución
Requisitos Previos
.NET Framework 4.5 o superior

Visual Studio o cualquier IDE compatible con C#

Pasos de Instalación
Clonar o descargar el proyecto

Abrir el proyecto en Visual Studio

Compilar la solución

Ejecutar el programa

Guía de Uso - Menú Principal
Opción 1: Crear Jugadores
Permite registrar nuevos jugadores en el sistema.

Proceso:

Ingresar nombre del jugador

Especificar edad

Definir características especiales (posición en deportes o rol en eSports)

Seleccionar tipo: "Deportes" o "eSports"

Ejemplo: Crear un jugador de fútbol llamado "Carlos", 25 años, posición "Delantero"

Opción 2: Crear Equipos
Crea nuevos equipos deportivos o de eSports.

Proceso:

Seleccionar tipo de equipo: "Deportes" o "eSports"

Ingresar nombre del equipo

Ejemplo: Crear equipo "Barcelona" tipo "Deportes"

Opción 3: Añadir Jugador a Equipo
Asigna jugadores disponibles a equipos específicos.

Proceso:

Seleccionar tipo de equipo (Deportes/eSports)

Elegir jugador de la lista de disponibles

Seleccionar equipo destino

Nota: Solo muestra jugadores sin equipo asignado

Opción 4: Crear Torneo
Organiza competencias entre equipos.

Proceso:

Ingresar nombre del torneo

Seleccionar tipo (Deportes/eSports)

Elegir cantidad de equipos (4 u 8)

Seleccionar equipos participantes

Funcionalidad: Genera brackets automáticamente y simula toda la competencia

Opción 5: Historial de Torneos
Muestra el historial completo de todos los torneos realizados.

Información mostrada:

Nombre del torneo

Equipos participantes

Posiciones finales

Ganador y MVP

Opción 6: Mostrar Ranking general de Jugadores
Presenta clasificación de jugadores por nivel.

Criterios:

Ordenado por nivel descendente

Muestra estadísticas individuales

Incluye equipo actual

Opción 7: Calcular promedio de nivel de equipo
Calcula el nivel promedio de un equipo específico.

Proceso:

Seleccionar tipo de equipo

Elegir equipo de la lista

Sistema calcula automáticamente

Cálculo: Suma de niveles de jugadores / cantidad de jugadores

Opción 8: Mostrar jugadores de torneo
Lista todos los jugadores participantes en un torneo específico.

Proceso:

Seleccionar torneo de la lista

Ver jugadores por equipo

Opción 9: Estadísticas individuales y por equipos
Genera reportes estadísticos detallados.

Opciones:

Estadísticas individuales: Datos completos de cada jugador

Estadísticas por equipos: Resumen por equipo con promedios

Opción 10: Quitar jugadores de equipos
Remueve jugadores de sus equipos actuales.

Proceso:

Seleccionar tipo de equipo

Elegir equipo

Seleccionar jugador a remover

Resultado: Jugador vuelve a estar disponible

Opción 11: Logros y MVP
Muestra sistema de reconocimientos y jugadores más valiosos.

Información:

Logros de equipos (campeonatos)

Logros individuales (MVP)

Estadísticas de logros

Jugador y equipo con más logros

Opción 12: Partido amistoso
Simula un partido entre dos equipos.

Proceso:

Seleccionar tipo de equipos

Elegir dos equipos

Sistema simula resultado

Designa MVP automáticamente

Característica: MVP mejora sus estadísticas

Opción 13: Comparar puntuaciones
Herramienta de análisis comparativo.

Opciones:

Comparar dos jugadores: Nivel, edad, estadísticas

Comparar dos equipos: Promedio, cantidad de jugadores

Opción 14: Salir
Finaliza la ejecución del programa.

Estructura del Código
Clases Principales
Player<T>
Gestiona la información de los jugadores:

Nombre, edad, nivel

Características especiales

Estadísticas y equipo asignado

Team<T>
Administra los equipos:

Nombre del equipo

Lista de jugadores

Tipo de equipo (Deportes/eSports)

Tournament<T>
Organiza los torneos:

Nombre del torneo

Tipo de torneo

Lista de participantes

Métodos Destacados
CrearJugador(): Registra nuevos jugadores

CrearTorneo(): Gestiona torneos automáticos

CalculateAverage(): Calcula promedios de equipo

ActualizarStats(): Sistema de progresión

RankingJugadores(): Clasificación por nivel

Sistema de Niveles
Los jugadores evolucionan mediante un sistema de estrellas basado en su nivel:

0-4.9: 1 estrella

5-9.9: 2 estrellas

10-14.9: 3 estrellas

15-19.9: 4 estrellas

20-25: 5 estrellas

Ejemplos de Uso
Crear un Jugador de Fútbol
text
----MENU----
1. Crear Jugadores
> 1
Escriba el nombre del Jugador: Luis
Escribe la edad del Jugador: 25
Escribe las caracteristicas especiales del jugador: Portero
Escribe si sera un jugador de Deportes o de eSports: Deportes
Organizar un Torneo de 4 Equipos
text
----MENU----
4. Crear Torneo
> 4
¿Como se llamara el Torneo? Copa America
¿De que tipo sera el torneo? Deportes/eSports? Deportes
¿Cuantos equipos deseas agregar al torneo? 4 u 8? 4
Contribución

Licencia
Este proyecto está bajo la Licencia UMAD.

Autor
Desarrollador - Hisham Yael Rosales Morales
Desarrollador - Debanhi Abigail Librado Almada
Desarrollador - Jesus Elias Guerrero Corral


Contacto
Email: iin2157@umad.edu.mx

LinkedIn: [Tu perfil de LinkedIn]

GitHub: [Tu usuario de GitHub]
