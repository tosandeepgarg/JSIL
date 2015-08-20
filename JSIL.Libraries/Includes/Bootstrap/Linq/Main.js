"use strict";

if (typeof (JSIL) === "undefined")
    throw new Error("JSIL.Core is required");

if (!$jsilcore)
    throw new Error("JSIL.Core is required");

JSIL.DeclareNamespace("System.Linq");
JSIL.DeclareNamespace("System.Linq.Expressions");

JSIL.MakeClass("System.Object", "JSIL.AbstractEnumerable", true, ["T"], function ($) {
    var T = new JSIL.GenericParameter("T", "JSIL.AbstractEnumerable");

    $.Method({ Static: false, Public: true }, ".ctor",
      new JSIL.MethodSignature(null, [JSIL.AnyType, JSIL.AnyType, JSIL.AnyType]),
      function (getNextItem, reset, dispose) {
          if (arguments.length === 1) {
              this._getEnumerator = getNextItem;
          } else {
              this._getEnumerator = null;
              this._getNextItem = getNextItem;
              this._reset = reset;
              this._dispose = dispose;
          }
      }
    );

    function getEnumeratorImpl() {
        if (this._getEnumerator !== null)
            return this._getEnumerator();
        else
            return new (JSIL.AbstractEnumerator.Of(this.T))(this._getNextItem, this._reset, this._dispose);
    };

    $.Method({ Static: false, Public: false }, null,
      new JSIL.MethodSignature($jsilcore.TypeRef("System.Collections.IEnumerator"), []),
      getEnumeratorImpl
    )
      .Overrides("System.Collections.IEnumerable", "GetEnumerator");

    $.Method({ Static: false, Public: true }, "GetEnumerator",
      new JSIL.MethodSignature($jsilcore.TypeRef("System.Collections.Generic.IEnumerator`1", [T]), []),
      getEnumeratorImpl
    )
      .Overrides("System.Collections.Generic.IEnumerable`1", "GetEnumerator");

    $.ImplementInterfaces(
      /* 0 */ $jsilcore.TypeRef("System.Collections.IEnumerable"),
      /* 1 */ $jsilcore.TypeRef("System.Collections.Generic.IEnumerable`1", [T])
    );
});

//? include("Classes/System.Linq.Enumerable.js"); writeln();

//? include("Classes/System.Linq.Expressions.Expression.js"); writeln();

//? include("Classes/System.Linq.Expressions.ConstantExpression.js"); writeln();

//? include("Classes/System.Linq.Expressions.TypedConstantExpression.js"); writeln();



JSIL.MakeClass($jsilcore.TypeRef("System.Linq.Expressions.Expression"), "System.Linq.Expressions.ParameterExpression", true, [], function ($) {
    var $thisType = $.publicInterface;
});

JSIL.MakeClass($jsilcore.TypeRef("System.Linq.Expressions.Expression"), "System.Linq.Expressions.LambdaExpression", true, [], function ($) {
    var $thisType = $.publicInterface;
});

JSIL.MakeClass($jsilcore.TypeRef("System.Linq.Expressions.LambdaExpression"), "System.Linq.Expressions.Expression`1", true, ["TDelegate"], function ($) {
    var $thisType = $.publicInterface;
});

JSIL.ImplementExternals("System.Linq.Expressions.Expression`1", function ($) {
});


JSIL.ImplementExternals("System.Linq.Expressions.ParameterExpression", function ($) {
    $.Method({ Static: true, Public: false }, "Make",
      new JSIL.MethodSignature($jsilcore.TypeRef("System.Linq.Expressions.ParameterExpression"), [
          $jsilcore.TypeRef("System.Type"), $.String,
          $.Boolean
      ], []),
      function Make(type, name, isByRef) {
          var experession = new System.Linq.Expressions.ParameterExpression(name);
          experession._type = type;
          experession._isByRef = isByRef;
          return experession;
      }
    );

    $.Method({ Static: false, Public: true }, "get_Type",
      new JSIL.MethodSignature($jsilcore.TypeRef("System.Type"), [], []),
      function get_Type() {
          return this._type;
      }
    );

    $.Method({ Static: false, Public: true }, "get_IsByRef",
      new JSIL.MethodSignature($jsilcore.TypeRef("System.Boolean"), [], []),
      function get_IsByRef() {
          return this._isByRef;
      }
    );
});
