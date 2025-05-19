def Settings(**kwargs):
    return {
        'ls': {
            'server': 'omnisharp',
            'rootUri': 'file:Assembly-CSharp-Editor.csproj',
            'initializationOptions': {
                'useModernNet': True,
            }
        }
    }
