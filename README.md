```markdown
# Sistema de Gestión Deportiva 

## Descripción General

Sistema de gestión deportiva desarrollado en C# que permite administrar jugadores, equipos y torneos tanto para deportes tradicionales como para eSports. Incluye funcionalidades completas para crear, modificar y analizar datos deportivos.

## Estructura del Proyecto

### Espacio de Nombres Principal: 'ProyectoParcial'

### Clases Principales

#### **Program** (`Program.cs`)
- **Punto de entrada** de la aplicación (`Main`)
- **Menú interactivo** con 14 opciones
- **Datos de ejemplo** pre-cargados

#### **Player<T>**
Representa a un jugador con las siguientes propiedades:
- `NombreP`: Nombre del jugador
- `Edad`: Edad del jugador
- `Nivel`: Nivel de habilidad (0-25)
- `Especiales`: Características especiales/posición
- `Stats`: Clasificación por estrellas (⭐ a ⭐⭐⭐⭐⭐)
- `Equipo`: Equipo al que pertenece
- `TipoJ`: Tipo (Deportes/eSports)

#### **Team<T>**
Representa un equipo deportivo:
- `NombreTeam`: Nombre del equipo
- `Jugadores`: Lista de jugadores
- `TipoT`: Tipo (Deportes/eSports)

#### **Tournament<T>**
Gestiona torneos deportivos:
- `NombreTour`: Nombre del torneo
- `TipoTour`: Tipo de torneo
- `Participantes`: Lista de equipos participantes

#### **Achievement<T>**
Maneja logros y reconocimientos:
- `Titulo`: Título del logro
- `Descripcion`: Descripción detallada
- `Jugador`: Jugador asociado
- `Equipo`: Equipo asociado
- `Fecha`: Fecha del logro

#### **Partido<T>**
Controla partidos individuales:
- `EquipoLocal` y `EquipoVisitante`
- `PuntosLocal` y `PuntosVisitante`
- `Ganador`: Equipo ganador
- `MVP`: Jugador más valioso
- `Fecha`: Fecha del partido

#### **Metodos<T>**
Clase principal con la lógica de negocio que utiliza:
- **Listas**: Jugadores, torneos, logros, partidos
- **Diccionarios**: Equipos deportivos y eSports
- **Cola**: Turnos de jugadores
- **Pila**: Historial de torneos

##  Cómo Ejecutar el Programa

###  Prerrequisitos
- **.NET SDK** (versión 5.0 o superior recomendada)
- **Visual Studio** o **Visual Studio Code** (opcional)
- **Terminal/Consola** de comandos

##  Uso del Programa

Al iniciar, el sistema muestra un **menú interactivo** con 14 opciones:

###  Menú Principal
1. **Crear Jugadores** - Registrar nuevos jugadores
2. **Crear Equipos** - Formar nuevos equipos
3. **Añadir Jugador a Equipo** - Asignar jugadores a equipos
4. **Crear Torneo** - Organizar torneos (4 u 8 equipos)
5. **Historial de Torneos** - Ver torneos anteriores
6. **Ranking de Jugadores** - Clasificación por nivel
7. **Promedio de Equipo** - Calcular nivel promedio
8. **Jugadores de Torneo** - Listar participantes
9. **Estadísticas** - Individuales y por equipos
10. **Quitar Jugadores** - Remover de equipos
11. **Logros y MVP** - Reconocimientos y méritos
12. **Partido Amistoso** - Simular encuentros
13. **Comparar Puntuaciones** - Jugadores o equipos
14. **Salir** - Finalizar aplicación

## Características Destacadas

### Sistema de Niveles
- **Rango**: 0 a 25 puntos
- **Sistema de estrellas**:
  - 0-4: ⭐
  - 5-9: ⭐⭐
  - 10-14: ⭐⭐⭐
  - 15-19: ⭐⭐⭐⭐
  - 20-25: ⭐⭐⭐⭐⭐

### Sistema de Torneos
- **Formatos**: 4 u 8 equipos
- **Emparejamientos aleatorios**
- **Actualización automática** de niveles según posición
- **Generación automática** de logros y MVP

###  Estadísticas Avanzadas
- **Rankings** detallados
- **Comparativas** entre jugadores/equipos
- **Estadísticas individuales** y colectivas
- **Historial completo** de rendimiento

##  Estructura de Datos Utilizadas

- **Listas**: Almacenamiento principal
- **Diccionarios**: Búsqueda eficiente de equipos
- **Colas**: Gestión de turnos
- **Pilas**: Historial y deshacer operaciones

##  Ejemplo de Uso

1. **Crear un jugador**:
   ```
   Nombre: Luis
   Edad: 25
   Especialidad: Portero
   Tipo: Deportes
   ```

2. **Crear un equipo**:
   ```
   Nombre: Barcelona
   Tipo: Deportes
   ```

3. **Organizar torneo**:
   ```
   Nombre: Champions League
   Tipo: Deportes
   Equipos: 8
   ```

##  Datos de Ejemplo Incluidos

El sistema viene pre-cargado con:
- **8 equipos** deportivos
- **24 jugadores** de diferentes posiciones
- **1 equipo** de eSports
- **Sistema de asignación** automática inicial

## Flujo de Trabajo Recomendado

1. Crear jugadores y equipos
2. Asignar jugadores a equipos
3. Organizar torneos
4. Analizar estadísticas y rankings
5. Gestionar logros y reconocimientos

##  Solución de Problemas

Si encuentras errores:
- Asegúrate de tener **permisos de ejecución**
- Revisa que no haya **errores de sintaxis** al copiar el código

## Notas Adicionales

- El sistema utiliza **genéricos** para flexibilidad
- **Persistencia en memoria** (los datos se pierden al cerrar)
- Interfaz **colorida** en consola para mejor experiencia
- **Validaciones** integradas para entradas de usuario

¡Disfruta gestionando tu mundo deportivo! 🏀⚽🎮
```
