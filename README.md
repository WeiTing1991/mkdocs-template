# docs-template

Documentation template using [Zensical](https://zensical.org/) with Python, C++, and C# support.

Built with auto-generated API documentation:
- **Python**: [mkdocstrings](https://mkdocstrings.github.io/) (from docstrings)
- **C++ / C#**: [MkDoxy](https://mkdoxy.kubaandrysek.cz/) (from Doxygen comments)

## Prerequisites

- [Python 3.12+](https://www.python.org/downloads/)
- [uv](https://docs.astral.sh/uv/getting-started/installation/)
- [Doxygen](https://www.doxygen.nl/download.html) (for C++/C# API docs)

## Quick Start

```bash
git clone https://github.com/WeiTing1991/docs-template.git
cd docs-template
uv sync
uv run zensical serve
```

Open `http://localhost:8000` in your browser.

## Build

```bash
uv run zensical build
```

## Deploy

Deployment to GitHub Pages is automatic on push to `main` via GitHub Actions.

## Customization

1. Replace `src/` files with your source code
2. Update `docs/` with your content
3. Edit `zensical.toml` to adjust site config
4. Delete language sections you don't need from `docs/` and the nav in `zensical.toml`

## Fallback

A `mkdocs.yml` config is included for backward compatibility with MkDocs 1.x.
