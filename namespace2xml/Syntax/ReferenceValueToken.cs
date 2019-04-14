﻿namespace Namespace2Xml.Syntax
{
    public sealed class ReferenceValueToken : IValueToken
    {
        public ReferenceValueToken(QualifiedName name)
        {
            Name = name;
        }

        public QualifiedName Name { get; }

        public override string ToString() => $"${{{Name}}}";
    }
}