using Prism.Events;
using System;

namespace SchemaDesigner.Events
{
    public class ApplicationNewEvent : PubSubEvent<string> { }
    public class ApplicationOpenEvent : PubSubEvent<string> { }
    public class ApplicationCloseEvent : PubSubEvent<bool> { }
    public class ApplicationSaveEvent : PubSubEvent<string> { }
    public class ApplicationSaveAsEvent : PubSubEvent<string> { }
    public class ApplicationUndoEvent : PubSubEvent<string> { }
    public class ApplicationRedoEvent : PubSubEvent<string> { }
    public class ApplicationCutEvent : PubSubEvent<string> { }
    public class ApplicationCopyEvent : PubSubEvent<string> { }
    public class ApplicationPasteEvent : PubSubEvent<string> { }
    public class ApplicationDeleteClassEvent : PubSubEvent<Guid> { }
    public class ApplicationDeleteInterfaceEvent : PubSubEvent<Guid> { }
    public class ApplicationDeletePropertyEvent : PubSubEvent<Guid> { }
    public class ApplicationAddClassEvent : PubSubEvent<string> { }
    public class ApplicationAddInterfaceEvent : PubSubEvent<string> { }
    public class ApplicationAddPropertyEvent : PubSubEvent<string> { }
    public class ApplicationImportClassEvent : PubSubEvent<string> { }
    public class ApplicationExportClassEvent : PubSubEvent<string> { }
    public class ApplicationReportAProblemEvent : PubSubEvent<string> { }
    public class ApplicationSuggestAFeatureEvent : PubSubEvent<string> { }
}
