namespace AngleSharp.Scripting.JavaScript
{
    using AngleSharp.Dom.Html;
    using Jint;
    using Jint.Native;
    using Jint.Native.Object;
    using Jint.Runtime;
    using Jint.Runtime.Descriptors;
    using Jint.Runtime.Interop;
    using System;

    sealed partial class HTMLFormControlsCollectionPrototype : HTMLFormControlsCollectionInstance
    {
        public HTMLFormControlsCollectionPrototype(Engine engine)
            : base(engine)
        {
            FastAddProperty("toString", Engine.AsValue(ToString), true, true, true);
        }

        public static HTMLFormControlsCollectionPrototype CreatePrototypeObject(EngineInstance engine, HTMLFormControlsCollectionConstructor constructor)
        {
            var obj = new HTMLFormControlsCollectionPrototype(engine.Jint)
            {
                Prototype = engine.Constructors.HTMLCollection.PrototypeObject,
                Extensible = true,
            };
            obj.FastAddProperty("constructor", constructor, true, false, true);
            return obj;
        }

        JsValue ToString(JsValue thisObj, JsValue[] arguments)
        {
            return "[object HTMLFormControlsCollection]";
        }

        void Fail(JsValue obsolete)
        {
            throw new JavaScriptException(Engine.TypeError);
        }
    }
}