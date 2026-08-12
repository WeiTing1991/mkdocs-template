# Getting Started

## Prerequisites

- [Python 3.12+](https://www.python.org/downloads/)
- [uv](https://docs.astral.sh/uv/getting-started/installation/)
- [Doxygen](https://www.doxygen.nl/download.html) (for C++/C# API docs)

## Installation

Clone the repository and install dependencies:

```bash
git clone https://github.com/WeiTing1991/mkdocs-template.git
cd mkdocs-template
uv sync
```

## Local Development

Start the development server:

```bash
uv run zensical serve
```

The site will be available at `http://localhost:8000`.

## Build

Build the static site:

```bash
uv run zensical build
```

Output goes to the `site/` directory.

## Project Structure

```
docs/           # Documentation source files
  python/       # Python docs and API reference
  cpp/          # C++ docs and API reference
  csharp/       # C# docs and API reference
src/            # Example source files for autodoc
  python/       # Python source with docstrings
  cpp/          # C++ source with Doxygen comments
  csharp/       # C# source with XML doc comments
zensical.toml   # Zensical config (primary)
mkdocs.yml      # MkDocs-compatible config (fallback)
pyproject.toml  # Python dependencies managed by uv
```

## Customization

1. Replace files in `src/` with your actual source code
2. Update `docs/` with your documentation content
3. Edit `zensical.toml` (or `mkdocs.yml`) to adjust site name, nav, and plugin paths
4. Delete language sections you don't need
