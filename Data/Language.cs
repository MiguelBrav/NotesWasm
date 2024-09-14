namespace NotesWasm.Data;

public class Language
{

    private static readonly Dictionary<string, Dictionary<string, string>> Translations = new Dictionary<string, Dictionary<string, string>>
    {
        { "HomeTitle", new Dictionary<string, string> { { "en", "Home" }, { "es", "Inicio" } } },
        { "NotesTitle", new Dictionary<string, string> { { "en", "Notes" }, { "es", "Notas" } } },
        { "Instruction", new Dictionary<string, string> { { "en", "Add your local user name" }, { "es", "Agrega tu nombre de usuario local" } } },
        { "Greetings", new Dictionary<string, string> { { "en", "Welcome!" }, { "es", "Bienvenido!" } } },
        { "MessageWelcome", new Dictionary<string, string> {
        { "en", "In this web application, you can save personal notes quickly and easily. You can add, edit, and delete your notes at any time, keeping all your information organized and accessible. Start managing your ideas and reminders today!" }, 
        { "es", "En esta aplicación web, tienes la capacidad de guardar notas personales de manera rápida y sencilla. Puedes añadir, editar y eliminar tus notas en cualquier momento, manteniendo toda tu información organizada y accesible. ¡Empieza a gestionar tus ideas y recordatorios hoy mismo!" } } },
        { "Add", new Dictionary<string, string> { { "en", "Add" }, { "es", "Agregar" } } },
        { "Edit", new Dictionary<string, string> { { "en", "Edit" }, { "es", "Editar" } } },
        { "Delete", new Dictionary<string, string> { { "en", "Delete" }, { "es", "Eliminar" } } },
        { "Save", new Dictionary<string, string> { { "en", "Save" }, { "es", "Guardar" } } },
        { "User", new Dictionary<string, string> { { "en", "User" }, { "es", "Usuario" } } },
        { "Title", new Dictionary<string, string> { { "en", "Title" }, { "es", "Título" } } },
        { "Content", new Dictionary<string, string> { { "en", "Description" }, { "es", "Descripción" } } },
        { "Actions", new Dictionary<string, string> { { "en", "Actions" }, { "es", "Acciones" } } },
        { "Return", new Dictionary<string, string> { { "en", "Return" }, { "es", "Volver" } } },
        { "Page", new Dictionary<string, string> { { "en", "Page" }, { "es", "Página" } } },
        { "ReturnConfirm", new Dictionary<string, string> { { "en", "¿Do you want to go back to notes without saving?" }, 
        { "es", "¿Deseas volver a las notas sin guardar?" } } },
        { "ConfirmTitle", new Dictionary<string, string> { { "en", "Confirm" }, { "es", "Confirmar" } } },
        { "Accept", new Dictionary<string, string> { { "en", "Accept" }, { "es", "Aceptar" } } },
        { "Close", new Dictionary<string, string> { { "en", "Close" }, { "es", "Cerrar" } } },
        { "DeleteConfirm", new Dictionary<string, string> { { "en", "¿Do you want to delete this note: {0}?" },
        { "es", "¿Deseas eliminar esta nota: {0}?" }} },
        { "DeleteAllConfirm", new Dictionary<string, string> { { "en", "¿Do you want to delete all notes?" },
        { "es", "¿Deseas eliminar todas las notas?" } } },
        { "DeleteAll", new Dictionary<string, string> { { "en", "Delete All" },
        { "es", "Borrar todo" } } }
    };

    public static string GetTranslation(string key, string languageCode)
    {
        if (Translations.TryGetValue(key, out var translations) &&
            translations.TryGetValue(languageCode, out var translation))
        {
            return translation;
        }
        return key;
    }

}

