# Contribution Guidelines

This document describes how developers should contribute to this repository. First of all these rules are for the core team, but if one wishes to take part in development than one should read rules carefully and follow them.

## How We Develop Projects?

1. :thinking: **Problem**

   Entry point for any project. It can be a business problem or personal, but still it's something we can overcome, improve or automate with code.

2. :bar_chart: **Analysis**

   No matter how big project is we should think carefully before development. There we define who is the _Target Users_ for our solution, come up with _Killer Features_, analyze _Problem Domain_ following [DDD](https://en.wikipedia.org/wiki/Domain-driven_design) principles, design project _Architecture_.

   Results of analysis should be formatted and exposed in project Wiki.

3. :pencil: **Formalization with Technical Task**

   The last thing before actual development, there we design our basic view of the project, formalize result of analysis with some clear text (Technical Task) & Schemes.

   TT is converted into GitHub Issues and organized in Kanban Boards.

4. :computer: **Development**

   Following principles of [Extreme Programming](<https://www.agilealliance.org/glossary/xp/#q=~(infinite~false~filters~(postType~(~'post~'aa_book~'aa_event_session~'aa_experience_report~'aa_glossary~'aa_research_paper~'aa_video)~tags~(~'xp))~searchTerm~'~sort~false~sortDirection~'asc~page~1)>) we try to bring life into our ides.

5. :beetle: **Testing**

   We write automated unit & integration tests following Test Driven Development practice where it's possible.

6. :thumbsup: **Release!!!**

   Release is always a _working_ project that tends to final version on each iteration.

It is as simple as Agile.

![](https://hackernoon.com/drafts/6t8232hs.png)

## Contributing

Good start is creating an Issue. For this reason we have some templates you can use for making it perfect:

- **Groundwork**

  Use this one if you need to describe some piece of work that just _should_ be done.

  _Examples_:

  - define project structure
  - setup infrastructure elements
  - setup CI/CD

  It's alright if **Groundwork** Issue replicates another Issue. Perfect situation is when some **Feature Request** (see next) is devided into several more technically detailed **Groundwork**s. In this case be sure that **Feature Request** is more general than **Groundwork** & don't forget to reference it with `#...` link.

  Of course **Groundwork** can & should be standalon Issue.

- **Feature Request**

  Use it when you have some new functionality to add or change behavior of the existing one.

  _Examples_:

  - authentication guard
  - new day event emission service

- **Bug Report**

  When you found that something went wrong do not panic! Just investigate bug as good as you can & make new **Bug Report** where you explain what is wrong, why and how it should be.

### Making Ideal Bug Report

If you found a bug or some unexpected behavior, please follow the steps below:

1. :mag_right: Check if this is a new bug by visiting project Issues and looking through one marked with `bug` label
2. :loudspeaker: Create a new issue and fill it according to _Bug Report_ issue template

When writing Bug Report please remember to provide _full_ and _clear_ description of everything that can help with debugging and be ready to answer questions from developers and further edits to Issue message.

### Making Ideal Feature Request

When asking for a new feature please follow these steps:

1. :mag_right: Check if your idea is not already described in Issues of the project (or maybe something close to our idea. If so suggest you view on the problem)
2. :loudspeaker: Create new **Feature Request** based on template.

Keep in mind that new functionality should be properly motivated & explained so be patient, accurate & clear writing new **Feature Request**, be ready for discussion & critics.

There is no need to get deeply into technical details.

### Making Ideal Groundwork Issue

As usual your way starts with Issues tab on repository page

1. :mag_right: Check if your **Groundwork** Issue won't be a duplicate
2. :loudspeaker: Create new **Groundwork** Issue following the structure of template

Remember that if you have any ideas on how something should be implemented it is the place to share them & bring to discussion.

### Making Ideal Pull Request

If you developed something (of course based on some issue) you should always create Pull Request to development branch (`master` by default) providing full description & explanation of work you've done.

It's not necessary to include hand written change log in PR message. Your commit history should be clear enough to let people figure out what you was done.

Remember to ask for review at least 2 developers & explain any questions without communication abuse.

### Reviewing Code

There are 2 types of code review:

- Offline code review

  This type of code review is used when we want to check important changes & share ideas & implementations with the entire team. This is a huge discussion over really important issues.

- Online code review

  Quick & simple but still important kind of review, where 2+ developers leave their comments on pull request

When reviewing code remember to be patient and respectful.

Remember: there is no ideal code.

## Style Guide

To develop projects efficiently this strict style guides are provided. They are used for quicker code reviews & easy maintenance.

> Provide code style guides for all languages used. If there is a perfect linter that fully utilizes your needs just reference it with packages for code editors

### Repository Naming

We recommend using `skewer-case` wherever it's possible

### Git Commit Messages Style Guide

- Start commit message with the issue tag you are working on: `issues/374 add...`
- Use the present tense (`... add ...` not `... added ...`)
- Use the imperative mood ("... move the cursor to..." not "... moves the cursor to...")
- Limit the first line to 72 characters or less
- Reference issues and pull requests liberally after the first line

### Branch Naming

As branch is always (except a couple of specific cases) is bound to some Issue than name them with the following template:

`issues/XXX issue_title_there`

Also, there are some special branches for different purposes

- `master` - is for storing in-development project versions and making some non-code edits
- `release` - stores only release versions of the project

### Issue and Pull Request Labels

To quickly describe state and category of issue or pull request use the following labels.

**Issue Kind Labels**

| **Label name** | **Description**                                           |
| -------------- | --------------------------------------------------------- |
| `feature`      | Feature requests                                          |
| `bug`          | Confirmed bugs or reports that are very likely to be bugs |
| `groundwork`   | Groundwork                                                |
| `question`     | This issue needs some discussion                          |

**Pull Request State Labels**

| **Label name**     | **Description**                                                         |
| ------------------ | ----------------------------------------------------------------------- |
| `wip`              | Pull requests which are still being worked on, more changes will follow |
| `needs-reviews`    | Code review is needed                                                   |
| `requires-changes` | Needs to be updated according to review                                 |

**Category Labels**

| **Label name** | **Description**                                                   |
| -------------- | ----------------------------------------------------------------- |
| `urgent`       | Should be resolved as quickly as possible                         |
| `important`    | Key issue                                                         |
| `challenge`    | A steep climb, not a long walk                                    |
| `performance`  | Related to project performance                                    |
| `analysis`     | Related to problem domain                                         |
| `architecture` | Related to project architecture                                   |
| `experimental` | Research in terms of project                                      |
| `help-wanted`  | Developer is stuck and waits for help                             |
| `blocked`      | Cannot be resolved because of some other issues and pull requests |
